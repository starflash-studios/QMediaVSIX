using System.Globalization;
using System.Windows.Media;

using MedColor = System.Windows.Media.Color;

namespace QMediaVSIX.Converters;

internal class ColourBrightnessContrastConverter : ValueConverter<SolidColorBrush, SolidColorBrush> {

    int _IncreaseAmount;
    public int IncreaseAmount {
        get => _IncreaseAmount;
        set => RaiseAndSetIfChanged(ref _IncreaseAmount, value);
    }

    /// <inheritdoc />
    public override bool CanReverse => false;

    /// <inheritdoc />
    public override SolidColorBrush Forward( SolidColorBrush From, object? Parameter = null, CultureInfo? Culture = null ) => new SolidColorBrush(IncreaseBrightnessContrast(From.Color, IncreaseAmount));

    //internal static MedColor GetMediaColour( Color Colour ) => MedColor.FromArgb(Colour.A, Colour.R, Colour.G, Colour.B);

    //internal static Color Increase( Color Col, int Amn ) => Color.FromArgb(Col.A, Col.R + Amn, Col.G + Amn, Col.B + Amn);

    //internal static Color IncreaseBrightnessContrast( Color Col, int Amn ) => Color.FromArgb(Col.A, Col.R >= 128 ? Col.R - Amn : Col.R + Amn, Col.G >= 128 ? Col.G - Amn : Col.G + Amn, Col.B >= 128 ? Col.B - Amn : Col.B + Amn);

    internal static MedColor IncreaseBrightnessContrast( MedColor Col, int Amn ) => MedColor.FromArgb(Col.A, (byte)(Col.R >= 128 ? Col.R - Amn : Col.R + Amn), (byte)(Col.G >= 128 ? Col.G - Amn : Col.G + Amn), (byte)(Col.B >= 128 ? Col.B - Amn : Col.B + Amn));

    //internal static Color InvertBrightness( Color Col ) => Color.FromArgb(Col.A, InvertBrightness(Col.R), InvertBrightness(Col.G), InvertBrightness(Col.B));

    //internal static int InvertBrightness( int A ) => A >= 128 ? 128 - A : A;

    /// <inheritdoc />
    public override SolidColorBrush? Reverse( SolidColorBrush To, object? Parameter = null, CultureInfo? Culture = null ) => null;
}