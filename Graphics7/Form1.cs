using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graphics7
{
    public partial class MainWindow : Form
    {
        bool draw = false;
        bool imExists = false;
        bool saved = true;

        string filepath = "";

        public MainWindow()
        {
            InitializeComponent();
            this.Text = "Graphics-7";
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;
            int value = tb.Value;
            string labelname = tb.Name + "val";
            Label val = Controls["panel1"].Controls[labelname] as Label;
            val.Text = value.ToString();
        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            int w = pictureBox.Width;
            int h = pictureBox.Height;
            Bitmap im = new Bitmap(w,h);
            Graphics img = Graphics.FromImage(im);
            img.FillRectangle(Brushes.White, 0, 0, w, h);
            pictureBox.Image = im;
            imExists = true;
            filepath = "";
            this.Text = "NewImage.bmp*";
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open...";
            ofd.Filter = "Bitmap(*.bmp) | *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                this.Text = Path.GetFileName(filepath);
                if (pictureBox.Image != null)
                    pictureBox.Image.Dispose();
                pictureBox.Image = new Bitmap(ofd.FileName);
                imExists = true;
            }
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            if (!saved)
                Save();
        }

        private void Save()
        {
            if (filepath != "")
            {
                string message = "Вы хотите сохранить изменения в файле " + filepath + "?";
                DialogResult result = MessageBox.Show(message, "Graphics-7", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string temp = Path.GetDirectoryName(filepath)+"($$##$$).bmp";
                    pictureBox.Image.Save(temp);
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
              //      System.Threading.Thread.Sleep(5000);
                    File.Delete(filepath);
                    File.Move(temp, filepath);
                    pictureBox.Image = new Bitmap(filepath);


                    //File.Delete(filepath);
                    //pictureBox.Image.Save(filepath, System.Drawing.Imaging.ImageFormat.Bmp);
                    this.Text = this.Text.Remove(this.Text.Length - 1, 1);
                    saved = true;
                }
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save";
                sfd.Filter = "Bitmap|*.bmp";
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filepath = sfd.FileName;
                    pictureBox.Image.Save(filepath);
                    this.Text = Path.GetFileName(filepath);
                    saved = true;
                }
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void color_l_Click(object sender, EventArgs e)
        { 
            Label l = sender as Label;
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                l.BackColor = colorDialog1.Color;
            }
        }

        private Color get_col()
        {
            Color res = Color.FromArgb(trackBarOP.Value,color_l.BackColor.R, color_l.BackColor.G, color_l.BackColor.B);
            return res;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (imExists)
            {
                draw = true;
                Draw(e.X, e.Y);
                saved = false;
                if (!this.Text.Contains("*"))
                this.Text += "*";
            }
        }

        private void Draw(int ex, int ey)
        {
            Image im = pictureBox.Image;
            Color c = get_col();
            int thickness = trackBarTH.Value;
            Graphics g = Graphics.FromImage(im);

            // Make a GraphicsPath to represent the ellipse.
            Rectangle rect = new Rectangle(
                ex,ey,
                thickness,
                thickness);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);

            // Make a PathGradientBrush from the path.
            using (PathGradientBrush brush = new PathGradientBrush(path))
            {
                brush.CenterColor = c;
                brush.SurroundColors = new Color[] { Color.Transparent }; ;
                g.FillEllipse(brush, rect);
            }
            g.Save();
            pictureBox.Image = im;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Draw(e.X, e.Y);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save this image?", "Saving", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Save();
            }
        }
    }
}
