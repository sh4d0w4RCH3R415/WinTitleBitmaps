﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

/// <summary>
/// Contains pre-drawn bitmaps for your window's titlebar.
/// </summary>
public sealed class Bitmaps
{
	private const int pos = 11;
	private static string _instanceId = string.Empty;
	private const string _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
	// yes btw, I did randomly type character for this id, I was too lazy to code the id generator

	private byte GetColorBrightness(Color c) => (byte)((c.R + c.G + c.B) / 3);

	private Bitmap ConvertFromStream(Stream resStrm) => new Bitmap(resStrm);

	public Bitmaps(string instanceId)
	{
		if (instanceId != _instanceId)
			throw new InvalidOperationException("Bitmaps class must be accessed through the static Instance member and now through constructor.");

		_instanceId = string.Empty;
		for (int i = 0; i < _chars.Length; i++)
			_instanceId += _chars[new Random().Next(_chars.Length)];
	}

	/// <summary>
	/// An auto-generated instance of the <see cref="Bitmaps"/> type.
	/// </summary>
	public static Bitmaps Instance => new Bitmaps(_instanceId);

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
			Rectangle rect = new Rectangle(0, 0, BmpSize, BmpSize);

			switch (BmpType)
			{
				case BitmapType.Close:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.SmoothingMode = SmoothingMode.HighQuality;
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.X + pos),
							new Point(rect.X + rect.Width - pos, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos, rect.Y + pos),
							new Point(rect.X + pos, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.X + pos),
							new Point(rect.X + rect.Width - pos, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos, rect.Y + pos),
							new Point(rect.X + pos, rect.Y + rect.Height - pos));
					}
					break;
				case BitmapType.Maximize:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.SmoothingMode = SmoothingMode.HighQuality;
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.Y + pos),
							new Point(rect.X + pos, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.Y + rect.Height - pos),
							new Point(rect.X + rect.Width - pos, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos, rect.Y + rect.Height - pos),
							new Point(rect.X + rect.Width - pos, rect.Y + pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos, rect.Y + pos),
							new Point(rect.X + pos, rect.Y + pos));
					}
					break;
				case BitmapType.Minimize:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.SmoothingMode = SmoothingMode.HighQuality;
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.Y + (rect.Width / 2) + 1),
							new Point(rect.X + rect.Width - pos, rect.Y + (rect.Width / 2) + 1));
					}
					break;
				case BitmapType.Restore:
					int spaceDiff = 2;

					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.SmoothingMode = SmoothingMode.HighQuality;
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.Y + pos + spaceDiff),
							new Point(rect.X + pos, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos, rect.Y + rect.Height - pos),
							new Point(rect.X + rect.Width - pos - spaceDiff, rect.Y + rect.Height - pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos - spaceDiff, rect.Y + rect.Height - pos),
							new Point(rect.X + rect.Width - pos - spaceDiff, rect.Y + pos + spaceDiff));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos - spaceDiff, rect.Y + pos + spaceDiff),
							new Point(rect.X + pos, rect.Y + pos + spaceDiff));

						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos + spaceDiff, rect.Y + pos),
							new Point(rect.X + pos + spaceDiff, rect.Y + pos + spaceDiff));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + pos + spaceDiff, rect.Y + pos),
							new Point(rect.X + rect.Width - pos, rect.Y + pos));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos, rect.Y + pos),
							new Point(rect.X + rect.Width - pos, rect.Y + rect.Height - pos - spaceDiff));
						g.DrawLine(new Pen(BmpColor),
							new Point(rect.X + rect.Width - pos, rect.Y + rect.Height - pos - spaceDiff),
							new Point(rect.X + rect.Width - pos - spaceDiff, rect.Y + rect.Height - pos - spaceDiff));
					}
					break;
				case BitmapType.Help:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("WinTitleBitmaps.CustomBitmaps.question_mark.png");

						int pos2 = (int)(pos * 0.85);
						Bitmap bmp2 = ConvertFromStream(s);

						ImageAttributes imageAttr = new ImageAttributes();
						ColorMap clrMap = new ColorMap();

						clrMap.OldColor = Color.Black;
						clrMap.NewColor = BmpColor;

						ColorMap[] remapeTable = { clrMap };
						imageAttr.SetRemapTable(remapeTable, ColorAdjustType.Bitmap);

						g.DrawImage(bmp2, new Rectangle(
							rect.X + pos2, rect.Y + pos2, rect.Width - (pos2 * 2), rect.Height - (pos2 * 2)
							), 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imageAttr);
					}
					break;
				case BitmapType.DownArrow:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("WinTitleBitmaps.CustomBitmaps.down.png");

						int pos2 = (int)(pos * 0.7);
						Bitmap bmp2 = ConvertFromStream(s);

						ImageAttributes imageAttr = new ImageAttributes();
						ColorMap clrMap = new ColorMap();

						clrMap.OldColor = Color.Black;
						clrMap.NewColor = BmpColor;

						ColorMap[] remapeTable = { clrMap };
						imageAttr.SetRemapTable(remapeTable, ColorAdjustType.Bitmap);

						g.DrawImage(bmp2, new Rectangle(
							rect.X + pos2, rect.Y + pos2 + 1, rect.Width - (pos2 * 2), rect.Height - (pos2 * 2)
							), 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imageAttr);
					}
					break;
				case BitmapType.UpArrow:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("WinTitleBitmaps.CustomBitmaps.up.png");

						int pos2 = (int)(pos * 0.7);
						Bitmap bmp2 = ConvertFromStream(s);

						ImageAttributes imageAttr = new ImageAttributes();
						ColorMap clrMap = new ColorMap();

						clrMap.OldColor = Color.Black;
						clrMap.NewColor = BmpColor;

						ColorMap[] remapeTable = { clrMap };
						imageAttr.SetRemapTable(remapeTable, ColorAdjustType.Bitmap);

						g.DrawImage(bmp2, new Rectangle(
							rect.X + pos2, rect.Y + pos2 + 1, rect.Width - (pos2 * 2), rect.Height - (pos2 * 2)
							), 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imageAttr);
					}
					break;
				case BitmapType.LeftArrow:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("WinTitleBitmaps.CustomBitmaps.left.png");

						int pos2 = (int)(pos * 0.7);
						Bitmap bmp2 = ConvertFromStream(s);

						ImageAttributes imageAttr = new ImageAttributes();
						ColorMap clrMap = new ColorMap();

						clrMap.OldColor = Color.Black;
						clrMap.NewColor = BmpColor;

						ColorMap[] remapeTable = { clrMap };
						imageAttr.SetRemapTable(remapeTable, ColorAdjustType.Bitmap);

						g.DrawImage(bmp2, new Rectangle(
							rect.X + pos2, rect.Y + pos2 + 1, rect.Width - (pos2 * 2), rect.Height - (pos2 * 2)
							), 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imageAttr);
					}
					break;
				case BitmapType.RightArrow:
					using (Graphics g = Graphics.FromImage(bmp))
					{
						Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("WinTitleBitmaps.CustomBitmaps.right.png");

						int pos2 = (int)(pos * 0.7);
						Bitmap bmp2 = ConvertFromStream(s);

						ImageAttributes imageAttr = new ImageAttributes();
						ColorMap clrMap = new ColorMap();

						clrMap.OldColor = Color.Black;
						clrMap.NewColor = BmpColor;

						ColorMap[] remapeTable = { clrMap };
						imageAttr.SetRemapTable(remapeTable, ColorAdjustType.Bitmap);

						g.DrawImage(bmp2, new Rectangle(
							rect.X + pos2, rect.Y + pos2 + 1, rect.Width - (pos2 * 2), rect.Height - (pos2 * 2)
							), 0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imageAttr);
					}
					break;
			}

			return bmp;
		}
	}
}
