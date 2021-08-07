using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			picClose.Image    = Bitmaps.Instance[32, Color.Black, BitmapType.Close];
			picMaximize.Image = Bitmaps.Instance[32, Color.Black, BitmapType.Maximize];
			picMinimize.Image = Bitmaps.Instance[32, Color.Black, BitmapType.Minimize];
			picRestore.Image  = Bitmaps.Instance[32, Color.Black, BitmapType.Restore];
			picHelp.Image     = Bitmaps.Instance[32, Color.Black, BitmapType.Help];
		}
	}
}
