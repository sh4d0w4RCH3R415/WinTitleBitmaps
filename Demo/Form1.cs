using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			picClose.Image      = Bitmaps.Instance[32, Color.Black, BitmapType.Close];
			picMaximize.Image   = Bitmaps.Instance[32, Color.Black, BitmapType.Maximize];
			picMinimize.Image   = Bitmaps.Instance[32, Color.Black, BitmapType.Minimize];
			picHelp.Image       = Bitmaps.Instance[32, Color.Black, BitmapType.Help];
			picDownArrow.Image  = Bitmaps.Instance[32, Color.Black, BitmapType.DownArrow];
			picUpArrow.Image    = Bitmaps.Instance[32, Color.Black, BitmapType.UpArrow];
			picLeftArrow.Image  = Bitmaps.Instance[32, Color.Black, BitmapType.LeftArrow];
			picRightArrow.Image = Bitmaps.Instance[32, Color.Black, BitmapType.RightArrow];
			
			picClose.MouseEnter      += new EventHandler(PictureBox_MouseEnter);
			picMaximize.MouseEnter   += new EventHandler(PictureBox_MouseEnter);
			picMinimize.MouseEnter   += new EventHandler(PictureBox_MouseEnter);
			picHelp.MouseEnter       += new EventHandler(PictureBox_MouseEnter);
			picDownArrow.MouseEnter  += new EventHandler(PictureBox_MouseEnter);
			picUpArrow.MouseEnter    += new EventHandler(PictureBox_MouseEnter);
			picLeftArrow.MouseEnter  += new EventHandler(PictureBox_MouseEnter);
			picRightArrow.MouseEnter += new EventHandler(PictureBox_MouseEnter);

			picClose.MouseLeave      += new EventHandler(PictureBox_MouseLeave);
			picMaximize.MouseLeave   += new EventHandler(PictureBox_MouseLeave);
			picMinimize.MouseLeave   += new EventHandler(PictureBox_MouseLeave);
			picHelp.MouseLeave       += new EventHandler(PictureBox_MouseLeave);
			picDownArrow.MouseLeave  += new EventHandler(PictureBox_MouseLeave);
			picUpArrow.MouseLeave    += new EventHandler(PictureBox_MouseLeave);
			picLeftArrow.MouseLeave  += new EventHandler(PictureBox_MouseLeave);
			picRightArrow.MouseLeave += new EventHandler(PictureBox_MouseLeave);

			picMaximize.MouseEnter += new EventHandler(Maximize_MouseEnter);
			picMaximize.MouseLeave += new EventHandler(Maximize_MouseLeave);
		}

		private void PictureBox_MouseEnter(object sender, EventArgs e) => ((PictureBox)sender).BackColor = Color.Gainsboro;
		private void PictureBox_MouseLeave(object sender, EventArgs e) => ((PictureBox)sender).BackColor = Color.White;

		private void Maximize_MouseEnter(object sender, EventArgs e) => picMaximize.Image = Bitmaps.Instance[32, Color.Black, BitmapType.Restore];
		private void Maximize_MouseLeave(object sender, EventArgs e) => picMaximize.Image = Bitmaps.Instance[32, Color.Black, BitmapType.Maximize];

		private void button1_Click(object sender, EventArgs e)
		{
			int x = picClose.Location.X;
			int y = picClose.Location.Y;

			Cursor.Position = PointToScreen(new Point(x, y));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int x = picRightArrow.Location.X + picRightArrow.Width;
			int y = picRightArrow.Location.Y + picRightArrow.Height;

			Cursor.Position = PointToScreen(new Point(x, y));
		}
	}
}
