// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TileBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Base class that describes a way to paint a region. Parent of ImageBrush.</summary>
  [Composable(typeof (ITileBrushFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ITileBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TileBrush : Brush, ITileBrush
  {
    /// <summary>Provides base class initialization behavior for TileBrush -derived classes.</summary>
    [MethodImpl]
    protected extern TileBrush();

    /// <summary>Gets or sets the horizontal alignment of content in the TileBrush base tile.</summary>
    /// <returns>A value that specifies the horizontal position of TileBrush content in its base tile. The default value is **Center**.</returns>
    public extern AlignmentX AlignmentX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of content in the TileBrush base tile.</summary>
    /// <returns>A value that specifies the vertical position of TileBrush content in its base tile. The default value is **Center**.</returns>
    public extern AlignmentY AlignmentY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how the content of this TileBrush stretches to fit its tiles.</summary>
    /// <returns>A value that specifies how this TileBrush content is projected onto its base tile. The default value is **Fill**.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the AlignmentX dependency property.</summary>
    /// <returns>The identifier for the AlignmentX dependency property.</returns>
    public static extern DependencyProperty AlignmentXProperty { [MethodImpl] get; }

    /// <summary>Identifies the AlignmentY dependency property.</summary>
    /// <returns>The identifier for the AlignmentY dependency property.</returns>
    public static extern DependencyProperty AlignmentYProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }
  }
}
