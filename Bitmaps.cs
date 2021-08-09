using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

/// <summary>
/// Contains pre-drawn bitmaps for your window's titlebar.
/// </summary>
public sealed class Bitmaps
{
	private const int pos = 8;
	private const float angline = 1.50005f;

	/// <summary>
	/// An auto-generated instance of the <see cref="Bitmaps"/> type.
	/// </summary>
	public static Bitmaps Instance => new Bitmaps();

	/// <summary>
	/// Generates a custom shape in the center of an image.
	/// </summary>
	/// <param name="BmpSize">The width/height (in pixels) of the image's size.</param>
	/// <param name="BmpColor">The color of the shape drawn on the bitmap.</param>
	/// <returns>A custom-drawn bitmap.</returns>
	public Bitmap this[int BmpSize, Color BmpColor, BitmapType BmpType]
	{
		get
		{
			Bitmap bmp = new Bitmap(BmpSize, BmpSize);

			switch (BmpType)
			{
				case BitmapType.Close:
					Point[] line1 = new Point[]
					{
						new Point(pos, pos),
						new Point(BmpSize - pos, BmpSize - pos),
					};
					Point[] line2 = new Point[]
					{
						new Point(pos, BmpSize - pos),
						new Point(BmpSize - pos, pos),
					};

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.SmoothingMode = SmoothingMode.HighQuality;
						gfx.DrawLines(new Pen(BmpColor, angline), line1);
						gfx.DrawLines(new Pen(BmpColor, angline), line2);
					}
					break;
				case BitmapType.Maximize:
					Point[] box = new Point[]
					{
						new Point(pos, pos),
						new Point(pos, BmpSize - pos),
						new Point(BmpSize - pos, BmpSize - pos),
						new Point(BmpSize - pos, pos),
						new Point(pos, pos),
					};

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.SmoothingMode = SmoothingMode.None;
						gfx.DrawLines(new Pen(BmpColor, 1), box);
					}
					break;
				case BitmapType.Minimize:
					PointF[] plate = new PointF[]
					{
						new PointF(pos, BmpSize / 2.0f),
						new PointF(BmpSize - pos, BmpSize / 2.0f),
					};

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.SmoothingMode = SmoothingMode.None;
						gfx.DrawLines(new Pen(BmpColor, 1), plate);
					}
					break;
				case BitmapType.Restore:
					Point[] box_ = new Point[]
					{
						new Point(pos, pos + 4),
						new Point(pos, BmpSize - pos),
						new Point(BmpSize - pos - 4, BmpSize - pos),
						new Point(BmpSize - pos - 4, pos + 4),
						new Point(pos, pos + 4),
					};
					Point[] line_ = new Point[]
					{
						new Point(pos + 4, pos),
						new Point(BmpSize - pos, pos),
					};
					Point[] line1_ = new Point[]
					{
						new Point(BmpSize - pos, pos),
						new Point(BmpSize - pos, BmpSize - pos - 4),
					};

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.SmoothingMode = SmoothingMode.None;
						gfx.DrawLines(new Pen(BmpColor, 1), box_);
						gfx.DrawLines(new Pen(BmpColor, 1), line_);
						gfx.DrawLines(new Pen(BmpColor, 1), line1_);
					}
					break;
				case BitmapType.Help:
					Rectangle textrect1 = new Rectangle(0, -1, BmpSize, BmpSize);
					Brush textbrush1 = new SolidBrush(BmpColor);

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
						gfx.DrawString("s", new Font("Webdings", 12f), textbrush1, textrect1,
							new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
					}
					break;
				case BitmapType.DownArrow:
					Rectangle textrect2 = new Rectangle(1, 1, BmpSize, BmpSize);
					Brush textbrush2 = new SolidBrush(BmpColor);

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
						gfx.DrawString("5", new Font("Webdings", 12f), textbrush2, textrect2,
							new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
					}
					break;
				case BitmapType.UpArrow:
					Rectangle textrect3 = new Rectangle(1, 0, BmpSize, BmpSize);
					Brush textbrush3 = new SolidBrush(BmpColor);

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
						gfx.DrawString("6", new Font("Webdings", 12f), textbrush3, textrect3,
							new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
					}
					break;
				case BitmapType.LeftArrow:
					Rectangle textrect4 = new Rectangle(1, 0, BmpSize, BmpSize);
					Brush textbrush4 = new SolidBrush(BmpColor);

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
						gfx.DrawString("3", new Font("Webdings", 12f), textbrush4, textrect4,
							new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
					}
					break;
				case BitmapType.RightArrow:
					Rectangle textrect5 = new Rectangle(0, 0, BmpSize, BmpSize);
					Brush textbrush5 = new SolidBrush(BmpColor);

					using (Graphics gfx = Graphics.FromImage(bmp))
					{
						gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
						gfx.DrawString("4", new Font("Webdings", 12f), textbrush5, textrect5,
							new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
					}
					break;
			}

			return bmp;
		}
	}
}
