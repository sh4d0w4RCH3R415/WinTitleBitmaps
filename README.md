## WinTitleBitmaps
### Description
Contains images that were drawn with code free to use for your window's titlebar if its a custom window!<br/>

Btw, I recommend setting the `SizeMode` of your `PictureBox` to be `PictureBoxSizeMode.CenterImage`, just so that it looks normal, and nice.

### How To Use
#### Quick Parameter Documentation
```csharp
using System.Drawing;

public sealed class Bitmaps
{
    public static Bitmaps Instance => new Bitmaps();

    public static Bitmap this[int BmpSize, Color BmpColor, BitmapType BmpType]
    {
        /* insert complex drawing code here */
    }
}
```
#### Actual "How To Use" Code
```csharp
using System.Drawing;
using System.Windows.Forms;

Bitmap close    = Bitmaps.Instance[32, Color.Black, BitmapType.Close];
Bitmap maximize = Bitmaps.Instance[32, Color.Black, BitmapType.Maximize];
Bitmap minimize = Bitmaps.Instance[32, Color.Black, BitmapType.Minimize];
Bitmap restore  = Bitmaps.Instance[32, Color.Black, BitmapType.Restore];
Bitmap help     = Bitmaps.Instance[32, Color.Black, BitmapType.Help];

// just pretend I modified the properties of these PictureBox controls
PictureBox myPicBox1 = new PictureBox();
PictureBox myPicBox2 = new PictureBox();
PictureBox myPicBox3 = new PictureBox();
PictureBox myPicBox4 = new PictureBox();
PictureBox myPicBox5 = new PictureBox();

myPicBox1.Image = close;
myPicBox2.Image = maximize;
myPicBox3.Image = minimize;
myPicBox4.Image = restore;
myPicBox5.Image = help;
```

### Bitmap Generation Results
![](https://github.com/sh4d0w4RCH3R415/WinTitleBitmaps/blob/master/screenshot%20of%20bitmaps.PNG)

### Download
[WinTitleBitmaps.dll](https://github.com/sh4d0w4RCH3R415/releases/download/1.0.0/WinTitleBitmaps.dll)
