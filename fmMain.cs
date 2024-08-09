using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dcm {
    public partial class fmMain : Form {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT {
            public int X;
            public int Y;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        readonly Bitmap output = new Bitmap(133, 133, PixelFormat.Format32bppArgb);
        Color color;

        public fmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// Form load and initialization.
        /// </summary>
        private void fmMain_Load(object sender, EventArgs e) {
            tbrUpdateSpeed.Value = Properties.Settings.Default.UpdateSpeedValue;
            rbRGB.Checked = Properties.Settings.Default.SaveColorRGBChecked;
            rbHEX.Checked = Properties.Settings.Default.SaveColorHEXChecked;
            cbRGB.Checked = Properties.Settings.Default.CopyColorListRGBChecked;
            cbHEX.Checked = Properties.Settings.Default.CopyColorListHEXChecked;
            trRefresh.Interval = 100 - tbrUpdateSpeed.Value;

            KeyDown += fmMain_KeyDown;
            lvColors.KeyDown += fmMain_KeyDown;
            tbRed.KeyDown += fmMain_KeyDown;
            tbGreen.KeyDown += fmMain_KeyDown;
            tbBlue.KeyDown += fmMain_KeyDown;
            rbRGB.KeyDown += fmMain_KeyDown;
            rbHEX.KeyDown += fmMain_KeyDown;
            cbRGB.KeyDown += fmMain_KeyDown;
            cbHEX.KeyDown += fmMain_KeyDown;
        }

        /// <summary>
        /// Form closing
        /// </summary>
        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Key shortcut handler.
        /// </summary>
        private void fmMain_KeyDown(object sender, KeyEventArgs e) {
            int.TryParse(tbRed.Text, out int r);
            int.TryParse(tbGreen.Text, out int g);
            int.TryParse(tbBlue.Text, out int b);

            var rgb =
                r + "," +
                g + "," +
                b;

            var hex =
                "#" +
                r.ToString("X") +
                g.ToString("X") +
                b.ToString("X");

            // Add a new list item with the current color.
            if (e.KeyCode == Keys.Space) {
                var item = new ListViewItem(
                    new[] {
                        "",
                        rgb,
                        hex
                    });

                using (Bitmap bitmap = new Bitmap(16, 16))
                {
                    using (Graphics gfx = Graphics.FromImage(bitmap))
                    {
                        var brush = new SolidBrush(Color.FromArgb(r, g, b));

                        gfx.FillRectangle(
                            brush,
                            0, 0,
                            15, 15);

                        ilColors.Images.Add(bitmap);
                        item.ImageIndex = ilColors.Images.Count - 1;

                        lvColors.Items.Add(item);
                    }
                }
            }

            // Copy the RGB value to clipboard directly.
            else if (e.Control &&
                     e.KeyCode == Keys.C) {
                if (rbRGB.Checked) {
                    Clipboard.SetText(rgb);
                }
                else if (rbHEX.Checked) {
                    Clipboard.SetText(hex);
                }
            }

            else if (e.Control &&
                     e.KeyCode == Keys.L) {
                var list = string.Empty;

                foreach (ListViewItem item in lvColors.Items) {
                    if (cbRGB.Checked) {
                        list += item.SubItems[1].Text;
                    }

                    if (cbRGB.Checked &&
                        cbHEX.Checked) {
                        list += "\t";
                    }

                    if (cbHEX.Checked) {
                        list += item.SubItems[2].Text;
                    }

                    list += "\r\n";
                }

                Clipboard.SetText(list);
            }
        }

        /// <summary>
        /// Refreshes the zoomed in area.
        /// </summary>
        private void refreshArea() {
            GetCursorPos(out POINT mousePos);

            using (Bitmap snapshot = new Bitmap(33, 33, PixelFormat.Format32bppArgb))
            {
                using (Graphics gfx = Graphics.FromImage(snapshot))
                {
                    var rx = 0;

                    gfx.CopyFromScreen(
                        mousePos.X - 16,
                        mousePos.Y - 16,
                        0,
                        0,
                        new Size(33, 33),
                        CopyPixelOperation.SourceCopy);

                    for (var x = 0; x < 33; x++)
                    {
                        var ry = 0;

                        for (var y = 0; y < 33; y++)
                        {
                            color = snapshot.GetPixel(x, y);

                            for (var rxs = rx; rxs < (rx + 5); rxs++)
                            {
                                for (var rys = ry; rys < (ry + 5); rys++)
                                {
                                    output.SetPixel(rxs, rys, color);
                                }
                            }

                            ry += 4;
                        }

                        rx += 4;
                    }

                    // Black square in the center of the aperture
                    for (var c = 63; c < 70; c++)
                    {
                        output.SetPixel(c, 63, Color.Black);
                        output.SetPixel(c, 69, Color.Black);

                        output.SetPixel(63, c, Color.Black);
                        output.SetPixel(69, c, Color.Black);
                    }

                    pbArea.Image = output;
                }
            }
        }

        /// <summary>
        /// Refresh the single color block and RGB values.
        /// </summary>
        private void refreshSinglePixel() {
            GetCursorPos(out POINT mousePos);

            var hdc = GetDC(IntPtr.Zero);
            var pixel = GetPixel(hdc, mousePos.X, mousePos.Y);

            ReleaseDC(IntPtr.Zero, hdc);

            color = Color.FromArgb(
                (int) (pixel & 0x000000FF),
                (int) (pixel & 0x0000FF00) >> 8,
                (int) (pixel & 0x00FF0000) >> 16);

            pbColor.BackColor = color;

            tbRed.Text = color.R.ToString(CultureInfo.InvariantCulture);
            tbGreen.Text = color.G.ToString(CultureInfo.InvariantCulture);
            tbBlue.Text = color.B.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Refresh ticker which forces the UI to update the color under the mouse pointer.
        /// </summary>
        private void trRefresh_Tick(object sender, EventArgs e) {
            refreshArea();
            refreshSinglePixel();
        }

        /// <summary>
        /// Copies the HEX value of the selected color to clipboard.
        /// </summary>
        private void miCopyHEX_Click(object sender, EventArgs e) {
            if (lvColors.SelectedItems.Count > 0) {
                Clipboard.SetText(
                    lvColors.SelectedItems[0].SubItems[2].Text);
            }
        }

        /// <summary>
        /// Copies the RGB value of the selected color to clipboard.
        /// </summary>
        private void miCopyRGB_Click(object sender, EventArgs e) {
            if (lvColors.SelectedItems.Count > 0) {
                Clipboard.SetText(
                    lvColors.SelectedItems[0].SubItems[1].Text);
            }
        }

        /// <summary>
        /// Copies the red RGB value of the selected color to clipboard.
        /// </summary>
        private void miCopyR_Click(object sender, EventArgs e) {
            if (lvColors.SelectedItems.Count <= 0) {
                return;
            }

            var colors = lvColors.SelectedItems[0].SubItems[1].Text.Split(',');
            Clipboard.SetText(colors[0]);
        }

        /// <summary>
        /// Copies the green RGB value of the selected color to clipboard.
        /// </summary>
        private void miCopyG_Click(object sender, EventArgs e) {
            if (lvColors.SelectedItems.Count <= 0) {
                return;
            }

            var colors = lvColors.SelectedItems[0].SubItems[1].Text.Split(',');
            Clipboard.SetText(colors[1]);
        }

        /// <summary>
        /// Copies the blue RGB value of the selected color to clipboard.
        /// </summary>
        private void miCopyB_Click(object sender, EventArgs e) {
            if (lvColors.SelectedItems.Count <= 0) {
                return;
            }

            var colors = lvColors.SelectedItems[0].SubItems[1].Text.Split(',');
            Clipboard.SetText(colors[2]);
        }

        private void tbrUpdateSpeed_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateSpeedValue = tbrUpdateSpeed.Value;
            trRefresh.Interval = 100 - Properties.Settings.Default.UpdateSpeedValue;
        }
        
        private void rbRGB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveColorRGBChecked = rbRGB.Checked;
            Properties.Settings.Default.SaveColorHEXChecked = !rbRGB.Checked;
        }

        private void rbHEX_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveColorRGBChecked = !rbHEX.Checked;
            Properties.Settings.Default.SaveColorHEXChecked = rbHEX.Checked;
        }

        private void cbRGB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CopyColorListRGBChecked = cbRGB.Checked;
        }

        private void cbHEX_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CopyColorListHEXChecked = cbHEX.Checked;
        }
    }
}