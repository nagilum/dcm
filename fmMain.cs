using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dcm
{
    public partial class fmMain : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
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

        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            this.lvColors.KeyDown += fmMain_KeyDown;
            this.tbRed.KeyDown += fmMain_KeyDown;
            this.tbGreen.KeyDown += fmMain_KeyDown;
            this.tbBlue.KeyDown += fmMain_KeyDown;
        }

        private void fmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
                return;

            var item = new ListViewItem(
                new string[]
                {
                    this.tbRed.Text,
                    this.tbGreen.Text,
                    this.tbBlue.Text
                });

            var r = 0;
            var g = 0;
            var b = 0;

            int.TryParse(this.tbRed.Text, out r);
            int.TryParse(this.tbGreen.Text, out g);
            int.TryParse(this.tbBlue.Text, out b);

            var bitmap = new Bitmap(16, 16);
            var gfx = Graphics.FromImage(bitmap);
            var brush = new SolidBrush(Color.FromArgb(r, g, b));

            gfx.FillRectangle(
                brush,
                0, 0,
                15, 15);

            this.ilColors.Images.Add((Image) bitmap);
            item.ImageIndex = this.ilColors.Images.Count - 1;
            
            this.lvColors.Items.Add(item);
        }

        private void refreshArea()
        {
            POINT mousePos;
            GetCursorPos(out mousePos);

            var snapshot = new Bitmap(33, 33, PixelFormat.Format32bppArgb);
            var output = new Bitmap(133, 133);
            var gfx = Graphics.FromImage(snapshot);
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
                    var color = snapshot.GetPixel(x, y);

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

            for (var c = 63; c < 70; c++)
            {
                output.SetPixel(c, 63, Color.Black);
                output.SetPixel(c, 69, Color.Black);

                output.SetPixel(63, c, Color.Black);
                output.SetPixel(69, c, Color.Black);
            }

            this.pbArea.Image = output;
        }

        private void refreshSinglePixel()
        {
            POINT mousePos;
            GetCursorPos(out mousePos);

            var hdc = GetDC(IntPtr.Zero);
            var pixel = GetPixel(hdc, mousePos.X, mousePos.Y);

            ReleaseDC(IntPtr.Zero, hdc);

            var color = Color.FromArgb(
                (int)(pixel & 0x000000FF),
                (int)(pixel & 0x0000FF00) >> 8,
                (int)(pixel & 0x00FF0000) >> 16);

            this.pbColor.BackColor = color;

            this.tbRed.Text = color.R.ToString();
            this.tbGreen.Text = color.G.ToString();
            this.tbBlue.Text = color.B.ToString();
        }

        private void trRefresh_Tick(object sender, EventArgs e)
        {
            this.refreshArea();
            this.refreshSinglePixel();
        }

        private void miCopyRGB_Click(object sender, EventArgs e)
        {
            if (this.lvColors.SelectedItems.Count > 0)
                Clipboard.SetText(
                    this.lvColors.SelectedItems[0].Text + "," +
                    this.lvColors.SelectedItems[0].SubItems[1].Text + "," +
                    this.lvColors.SelectedItems[0].SubItems[2].Text);
        }

        private void miCopyR_Click(object sender, EventArgs e)
        {
            if (this.lvColors.SelectedItems.Count > 0)
                Clipboard.SetText(
                    this.lvColors.SelectedItems[0].Text);
        }

        private void miCopyG_Click(object sender, EventArgs e)
        {
            if (this.lvColors.SelectedItems.Count > 0)
                Clipboard.SetText(
                    this.lvColors.SelectedItems[0].SubItems[1].Text);
        }

        private void miCopyB_Click(object sender, EventArgs e)
        {
            if (this.lvColors.SelectedItems.Count > 0)
                Clipboard.SetText(
                    this.lvColors.SelectedItems[0].SubItems[2].Text);
        }
    }
}
