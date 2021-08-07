using System;

/// <summary>
/// The type of bitmap shape to generate.
/// </summary>
public enum BitmapType
{
	/// <summary>
	/// Generate an 'X' shape.
	/// </summary>
	Close = 874892,

	/// <summary>
	/// Generate a 'box' shape.
	/// </summary>
	Maximize = 473282,

	/// <summary>
	/// Generate a 'plate' shape.
	/// </summary>
	Minimize = 183783,

	/// <summary>
	/// Generate a 'box overlaying another box' shape.
	/// </summary>
	Restore = 927582,

	/// <summary>
	/// Generate a 'question mark' shape.
	/// </summary>
	Help = 395839,
}

public static class BitmapTypeExtensions
{
	/// <summary>
	/// Converts an integer to a <see cref="BitmapType"/> object.
	/// </summary>
	/// <param name="ID">The id of the <see cref="BitmapType"/> enumeration to convert from.</param>
	/// <returns>
	/// A <see cref="BitmapType"/> <see langword="enumeration"/>, if the id matches one of the values.
	/// </returns>
	public static BitmapType ToBmpType(this int ID)
	{
		if (ID == 874892 || ID == 473282 || ID == 183783 || ID == 927582 || ID == 395839)
		{
			return (BitmapType)ID;
		}
		else throw new ArgumentException("The integer given does not match any of the BitmapType enumerations.", "ID");
	}

	/// <summary>
	/// Converts an unsigned integer to a <see cref="BitmapType"/> object.
	/// </summary>
	/// <param name="ID">The id of the <see cref="BitmapType"/> enumeration to convert from.</param>
	/// <returns>
	/// A <see cref="BitmapType"/> <see langword="enumeration"/>, if the id matches one of the values.
	/// </returns>
	public static BitmapType ToBmpType(this uint ID)
	{
		if (ID == 874892 || ID == 473282 || ID == 183783 || ID == 927582 || ID == 395839)
		{
			return (BitmapType)ID;
		}
		else throw new ArgumentException("The unsigned integer given does not match any of the BitmapType enumerations.", "ID");
	}
}
