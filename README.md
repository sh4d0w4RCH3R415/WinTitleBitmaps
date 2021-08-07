## WinTitleBitmaps
### Description
Contains images that were drawn with code free to use for your window's titlebar if its a custom window!

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

Bitmap close    = Bitmaps.Instance[32, Color.White, BitmapType.Close];
Bitmap maximize = Bitmaps.Instance[32, Color.White, BitmapType.Maximize];
Bitmap minimize = Bitmaps.Instance[32, Color.White, BitmapType.Minimize];
Bitmap restore  = Bitmaps.Instance[32, Color.White, BitmapType.Restore];
Bitmap help     = Bitmaps.Instance[32, Color.White, BitmapType.Help];
```
