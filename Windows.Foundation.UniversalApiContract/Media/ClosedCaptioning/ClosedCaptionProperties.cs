// Decompiled with JetBrains decompiler
// Type: Windows.Media.ClosedCaptioning.ClosedCaptionProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.ClosedCaptioning
{
  /// <summary>Exposes properties for retrieving the closed caption formatting settings that the user can set through the system's closed captioning settings page.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IClosedCaptionPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class ClosedCaptionProperties
  {
    /// <summary>Gets the font color for closed caption text.</summary>
    /// <returns>The font color for closed caption text.</returns>
    public static extern ClosedCaptionColor FontColor { [MethodImpl] get; }

    /// <summary>Gets the computed font color for closed caption text.</summary>
    /// <returns>The computed font color for closed caption text.</returns>
    public static extern Color ComputedFontColor { [MethodImpl] get; }

    /// <summary>Gets the font opacity for closed caption text.</summary>
    /// <returns>The font opacity for closed caption text.</returns>
    public static extern ClosedCaptionOpacity FontOpacity { [MethodImpl] get; }

    /// <summary>Gets the font size for closed caption text.</summary>
    /// <returns>The font size for closed caption text.</returns>
    public static extern ClosedCaptionSize FontSize { [MethodImpl] get; }

    /// <summary>Gets the font style for closed caption text.</summary>
    /// <returns>The font style for closed caption text.</returns>
    public static extern ClosedCaptionStyle FontStyle { [MethodImpl] get; }

    /// <summary>Gets the font effect for closed caption text.</summary>
    /// <returns>The font effect for closed caption text.</returns>
    public static extern ClosedCaptionEdgeEffect FontEffect { [MethodImpl] get; }

    /// <summary>Gets the background color of lines of closed caption text.</summary>
    /// <returns>The background color of lines of closed caption text.</returns>
    public static extern ClosedCaptionColor BackgroundColor { [MethodImpl] get; }

    /// <summary>Gets the computed background color of lines of closed caption text.</summary>
    /// <returns>The computed background color of lines of closed caption text.</returns>
    public static extern Color ComputedBackgroundColor { [MethodImpl] get; }

    /// <summary>Gets the background opacity of lines of closed caption text.</summary>
    /// <returns>The background opacity of lines of closed caption text.</returns>
    public static extern ClosedCaptionOpacity BackgroundOpacity { [MethodImpl] get; }

    /// <summary>Gets the region color for closed caption text.</summary>
    /// <returns>The region color for closed caption text.</returns>
    public static extern ClosedCaptionColor RegionColor { [MethodImpl] get; }

    /// <summary>Gets the computed region color for closed caption text.</summary>
    /// <returns>The computed region color for closed caption text.</returns>
    public static extern Color ComputedRegionColor { [MethodImpl] get; }

    /// <summary>Gets the region opacity for closed caption text.</summary>
    /// <returns>The region opacity for closed caption text.</returns>
    public static extern ClosedCaptionOpacity RegionOpacity { [MethodImpl] get; }
  }
}
