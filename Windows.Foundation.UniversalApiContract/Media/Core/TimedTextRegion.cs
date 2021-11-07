// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  /// <summary>Exposes properties for customizing the appearance of the rendering area of a TimedTextCue.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimedTextRegion : ITimedTextRegion
  {
    /// <summary>Initializes a new instance of the TimedTextRegion class.</summary>
    [MethodImpl]
    public extern TimedTextRegion();

    /// <summary>Gets or sets a string representing the name of the TimedTextRegion.</summary>
    /// <returns>The name of the TimedTextRegion.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the TimedTextRegion, relative to the top left corner of the video frame.</summary>
    /// <returns>The position of the TimedTextRegion</returns>
    public extern TimedTextPoint Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the extent of the TimedTextRegion, which is the rendered size of the region either in pixels or in percentage of available space.</summary>
    /// <returns>The extent of the TimedTextRegion.</returns>
    public extern TimedTextSize Extent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of the TimedTextRegion.</summary>
    /// <returns>The background color of the TimedTextRegion.</returns>
    public extern Color Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the direction that text flows within the TimedTextRegion.</summary>
    /// <returns>A value indicating the direction that text flows within the region.</returns>
    public extern TimedTextWritingMode WritingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display alignment of the TimedTextRegion.</summary>
    /// <returns>The display alignment of the TimedTextRegion.</returns>
    public extern TimedTextDisplayAlignment DisplayAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the height of each line of content.</summary>
    /// <returns>A value that indicates the height of each line of content.</returns>
    public extern TimedTextDouble LineHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether text overflowing the region is clipped.</summary>
    /// <returns>True if overflowing text is clipped; otherwise, false.</returns>
    public extern bool IsOverflowClipped { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a TimedTextRegion.</summary>
    /// <returns>A value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a TimedTextRegion.</returns>
    public extern TimedTextPadding Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether text wraps when it reaches the edge of the TimedTextRegion.</summary>
    /// <returns>A value indicating whether text wraps when it reaches the edge of the region.</returns>
    public extern TimedTextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Z-order of the TimedTextRegion, relative to other active regions on the screen, in case they overlap.</summary>
    /// <returns>The Z-order of the TimedTextRegion.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating the method in which lines of text scroll through the region.</summary>
    /// <returns>A value indicating the method in which lines of text scroll through the region.</returns>
    public extern TimedTextScrollMode ScrollMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
