# WinTitleBitmaps
## Description
Contains images that were drawn with code free to use for your window's titlebar if its a custom window!<br/>

Btw, I recommend setting the `SizeMode` of your `PictureBox` to be `PictureBoxSizeMode.CenterImage`, just so that it looks normal, and nice.

## How To Use
### Quick Parameter Documentation
The bitmap generator method requests a background color so that it can make the caption button image it returns more visible.
```csharp
using System.Drawing;

public enum BitmapType
{
    Close,
    Maximize,
    Minimize,
    Restore,
    Help,
    DownArrow,
    UpArrow,
    LeftArrow,
    RightArrow,
}

public sealed class Bitmaps
{
    public static Bitmaps Instance => new Bitmaps();

    public Bitmap this[int BmpSize, Color BmpColor, Color BmpBackground, BitmapType BmpType]
    {
        /* insert complex drawing code here */
    }
}
```
### Actual "How To Use" Code
```csharp
using System.Drawing;
using System.Windows.Forms;

Bitmap close      = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.Close     ];
Bitmap maximize   = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.Maximize  ];
Bitmap minimize   = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.Minimize  ];
Bitmap restore    = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.Restore   ];
Bitmap help       = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.Help      ];
Bitmap downArrow  = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.DownArrow ];
Bitmap upArrow    = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.UpArrow   ];
Bitmap leftArrow  = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.LeftArrow ];
Bitmap rightArrow = Bitmaps.Instance[32, Color.Black, Color.White, BitmapType.RightArrow];

// just pretend I modified the properties of these PictureBox controls
PictureBox myPicBox1 = new PictureBox();
PictureBox myPicBox2 = new PictureBox();
PictureBox myPicBox3 = new PictureBox();
PictureBox myPicBox4 = new PictureBox();
PictureBox myPicBox5 = new PictureBox();
PictureBox myPicBox6 = new PictureBox();
PictureBox myPicBox7 = new PictureBox();
PictureBox myPicBox8 = new PictureBox();
PictureBox myPicBox9 = new PictureBox();

myPicBox1.Image = close;
myPicBox2.Image = maximize;
myPicBox3.Image = minimize;
myPicBox4.Image = restore;
myPicBox5.Image = help;
myPicBox6.Image = downArrow;
myPicBox7.Image = upArrow;
myPicBox8.Image = leftArrow;
myPicBox9.Image = rightArrow;
```

## Bitmap Generation Results
![](https://raw.githubusercontent.com/sh4d0w4RCH3R415/WinTitleBitmaps/master/screenshot%20of%20bitmaps.jpg)
![](https://raw.githubusercontent.com/sh4d0w4RCH3R415/WinTitleBitmaps/master/screenshot%20of%20bitmaps%202.jpg)

## Download
[Standalone](https://github.com/sh4d0w4RCH3R415/releases/latest/download/WinTitleBitmaps.dll)
