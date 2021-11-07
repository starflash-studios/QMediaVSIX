// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the line display capabilities.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayCapabilities : ILineDisplayCapabilities
  {
    /// <summary>Gets whether the line display supports reporting statistics.</summary>
    /// <returns>True if the line display supports reporting statistics; otherwise, false.</returns>
    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports updating (or resetting) statistics.</summary>
    /// <returns>True if the line display supports updating statistics; otherwise, false.</returns>
    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    /// <summary>Gets the type of power reporting supported by the line display.</summary>
    /// <returns>This property can have one of the following values:</returns>
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports changing its screen size.</summary>
    /// <returns>True if the line display supports changing its screen size; otherwise, false.</returns>
    public extern bool CanChangeScreenSize { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports displaying bitmaps.</summary>
    /// <returns>True if the line display supports displaying bitmaps; otherwise, false.</returns>
    public extern bool CanDisplayBitmaps { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports reading characters at the current cursor position.</summary>
    /// <returns>True if the line display supports reading characters at the cursor; otherwise false.</returns>
    public extern bool CanReadCharacterAtCursor { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports mapping characters sets.</summary>
    /// <returns>True if the line display supports mapping character sets; otherwise false.</returns>
    public extern bool CanMapCharacterSets { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports displaying custom glyphs.</summary>
    /// <returns>True if the line display supports displaying custom glyphs; otherwise, false.</returns>
    public extern bool CanDisplayCustomGlyphs { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports reversing the video display.</summary>
    /// <returns>The support for reversing the video display.</returns>
    public extern LineDisplayTextAttributeGranularity CanReverse { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports blinking</summary>
    /// <returns>The support for blinking.</returns>
    public extern LineDisplayTextAttributeGranularity CanBlink { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports changing its blink rate.</summary>
    /// <returns>True if the line display supports changing its blink rate; otherwise, false.</returns>
    public extern bool CanChangeBlinkRate { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports adjusting the screen brightness.</summary>
    /// <returns>True if the line display supports adjusting the screen brightness; otherwise, false.</returns>
    public extern bool IsBrightnessSupported { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports a cursor.</summary>
    /// <returns>True if the line display supports a cursor; otherwise, false.</returns>
    public extern bool IsCursorSupported { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports horizontal marquee scrolling.</summary>
    /// <returns>True if the line display supports horizontal marquee scrolling; otherwise, false.</returns>
    public extern bool IsHorizontalMarqueeSupported { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports vertical marquee scrolling.</summary>
    /// <returns>True if the line display supports vertical marquee scrolling; otherwise, false.</returns>
    public extern bool IsVerticalMarqueeSupported { [MethodImpl] get; }

    /// <summary>Gets whether the line display supports delaying between displaying successive characters.</summary>
    /// <returns>True if the line display supports inter-character wait; otherwise, false.</returns>
    public extern bool IsInterCharacterWaitSupported { [MethodImpl] get; }

    /// <summary>Gets the number of descriptors supported by the line display.</summary>
    /// <returns>The number of descriptors supported by the line display. A value of zero indicates that the line display does not support descriptors.</returns>
    public extern uint SupportedDescriptors { [MethodImpl] get; }

    /// <summary>Gets the maximum number of windows supported by the line display.</summary>
    /// <returns>The maximum number of windows supported by the line display.</returns>
    public extern uint SupportedWindows { [MethodImpl] get; }
  }
}
