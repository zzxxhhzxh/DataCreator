using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;

namespace SimplePainter
{
    public partial class FrmMain : Form
    {
        Bitmap img, tmp;
        Point sPoint;
        bool isPointing = true;
        string strData = string.Empty;
      
        int x0, y0; //x0, y0 of Coodinates
        int w, h; //Width, Height of Coodinates
        int minX = 0, maxX = 100, minY = 0, maxY = 100, dX = 5, dY = 5; //Range of X, Y
        float rX, rY; //Ratio of X, Y with Width, Height

        int pGroup = 0;
        Color[] pColors = new Color[] { Color.DimGray, Color.Tomato, Color.LimeGreen, Color.DodgerBlue, Color.Gold, Color.SlateBlue };
        List<dPoint> lPoint = new List<dPoint>();

        public struct dPoint
        {
            public string T; //Time
            public int G; //Group
            public float X; //X Value
            public float Y; //Y Value

            public dPoint(DateTime time, int group, float x, float y)
            {
                T = time.ToString("T");
                G = group;
                X = (float)Math.Round(x, 3);
                Y = (float)Math.Round(y, 3);
            }
        }

        public FrmMain()
        {
            InitializeComponent();            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeCoordinate();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            minX = Convert.ToInt32(txtMinX.Text);
            maxX = Convert.ToInt32(txtMaxX.Text);
            minY = Convert.ToInt32(txtMinY.Text);
            maxY = Convert.ToInt32(txtMaxY.Text);
            dX = Convert.ToInt32(txtDX.Text);
            dY = Convert.ToInt32(txtDY.Text);
            lPoint = new List<dPoint>();
        }

        private void BtnNewCoord_Click(object sender, EventArgs e)
        {
            InitializeCoordinate();
        }

        private void BtnLoadPic_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Image File(*.bmp; *.jpg; *.png)| *.bmp; *.jpg; *.png" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadPic(dlg.FileName);
                picImg.Refresh();
                isPointing = false;
            }
        }

        private void BtnCreateData_Click(object sender, EventArgs e)
        {
            CreateData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog() { Filter = "Text File(*.txt)| *.txt" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(dlg.FileName, false))
                {
                    sw.Write(strData);
                }
                img.Save(dlg.FileName.Substring(0, dlg.FileName.Length - 3) + "png", ImageFormat.Png);
            }
        }

        private void picImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void picImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPointing)
            {
                using (var g = Graphics.FromImage(img))
                {
                    g.FillEllipse(new SolidBrush(pColors[pGroup]), e.X - 5, e.Y - 5, 10, 10);
                }
                var now = DateTime.Now;
                lPoint.Add(new dPoint(now, pGroup, minX + (e.X - x0) * rX, minY + (y0 - e.Y) * rY));
                picImg.Refresh();
            }
            else
            {
                sPoint = e.Location;
                picImg.MouseMove += new MouseEventHandler(picImg_MouseMove);
            }
        }

        private void picImg_MouseMove(object sender, MouseEventArgs e)
        {
            img = new Bitmap(tmp);
            using (var g = Graphics.FromImage(img))
                g.DrawRectangle(Pens.Tomato, sPoint.X, sPoint.Y, e.X - sPoint.X, e.Y - sPoint.Y);
            picImg.Refresh();
        }

        private void picImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPointing)
                return;
            picImg.MouseMove -= new MouseEventHandler(picImg_MouseMove);
            img = new Bitmap(tmp);
            x0 = sPoint.X;
            y0 = e.Y;
            w = e.X - sPoint.X;
            h = e.Y - sPoint.Y;
            SetCoordinate();
            isPointing = true;
        }

        private void SetCoordinate()
        {
            int nX = (maxX - minX) / dX;
            int nY = (maxY - minY) / dY;
            using (var g = Graphics.FromImage(img))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                for (int i = 0; i <= nX; i++)
                {
                    g.DrawLine(Pens.DimGray, x0 + i * w / nX, y0, x0 + i * w / nX, y0 - h - 10);
                    g.DrawString(Convert.ToString(minX + i * dX), new Font("Arial", 10), Brushes.Tomato, x0 - 10 + i * w / nX, y0 + 10);
                }
                for (int j = 0; j <= nY; j++)
                {
                    g.DrawLine(Pens.DimGray, x0, y0 - j * h / nY, w + x0 + 10, y0 - j * h / nY);
                    g.DrawString(Convert.ToString(minY + j * dY), new Font("Arial", 10), Brushes.Tomato, x0 - 30, y0 - 10 - j * h / nY);
                }
                g.DrawLine(Pens.DodgerBlue, x0, y0, w + x0 + 20, y0);
                g.DrawLine(Pens.DodgerBlue, x0, y0, x0, y0 - h - 20);
            }
            picImg.Refresh();
            rX = (maxX - minX) * 1.0f / w;
            rY = (maxY - minY) * 1.0f / h;
        }

        private void InitializeCoordinate()
        {
            x0 = 40;
            y0 = picImg.Height - 40;
            w = picImg.Width - x0 - 40;
            h = y0 - 40;
            img = new Bitmap(picImg.Width, picImg.Height);
            SetCoordinate();
        }

        private void ClickGroupRadios(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(((RadioButton)sender).Name.Substring(6));
            pGroup = i;
        }

        private void LoadPic(string file)
        {
            img = new Bitmap(picImg.Width, picImg.Height);
            float r = Math.Min(picImg.Width * 1.0f / Image.FromFile(file).Width, picImg.Height * 1.0f / Image.FromFile(file).Height);
            using (var g = Graphics.FromImage(img))
            {
                g.DrawImage(Image.FromFile(file), 0, 0, Image.FromFile(file).Width * r, Image.FromFile(file).Height * r);
            }
            tmp = new Bitmap(img);
        }

        private void CreateData()
        {
            var sb = new StringBuilder("X=[ [");
            int j = lPoint.Count - 1;

            if (rdoReg.Checked)
            {
                for (int i = 0; i < j; i++)
                    sb.Append($"{lPoint[i].X}], [");
                sb.Append($"{lPoint[j].X}] ]\nY=[ [");
                for (int i = 0; i < j; i++)
                    sb.Append($"{lPoint[i].Y}], [");
                sb.Append($"{lPoint[j].Y}] ]");
            }
            else if (rdoLog.Checked)
            {
                for (var i = 0; i < j; i++)
                    sb.Append($"{lPoint[i].G}, {lPoint[i].X}, {lPoint[i].Y}], \n[");
                sb.Append($"{lPoint[j].G}, {lPoint[j].X}, {lPoint[j].Y}] ]");
            }
            else
            {
                for (var i = 0; i < j; i++)
                    sb.Append($"{lPoint[i].T}, {lPoint[i].G}, {lPoint[i].X}, {lPoint[i].Y}], \n[");
                sb.Append($"{lPoint[j].T}, {lPoint[j].G}, {lPoint[j].X}, {lPoint[j].Y}] ]");
            }
            strData = sb.ToString();
            rtxData.Text = strData;
        }
    }
}