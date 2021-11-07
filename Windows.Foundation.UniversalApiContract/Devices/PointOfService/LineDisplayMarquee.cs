// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayMarquee
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents an object containing properties describing and allowing control of marquee scrolling on a line display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class LineDisplayMarquee : ILineDisplayMarquee
  {
    /// <summary>Gets or sets the current format of the marquee.</summary>
    /// <returns>The current format of the marquee.</returns>
    public extern LineDisplayMarqueeFormat Format { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the marquee repeat wait period.</summary>
    /// <returns>The delay between finishing a marquee scroll and starting over again.</returns>
    public extern TimeSpan RepeatWaitInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scroll wait interval.</summary>
    /// <returns>The delay between placing or walking each character in the marquee.</returns>
    public extern TimeSpan ScrollWaitInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Attempts to asynchronously cause the window which owns this marquee to enter Marquee Mode and start scrolling.</summary>
    /// <param name="direction">The direction in which to start scrolling.</param>
    /// <returns>Returns True if the marquee successfully started scrolling; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryStartScrollingAsync(
      LineDisplayScrollDirection direction);

    /// <summary>Attempts to asynchronously exit Marquee mode and/or Marquee Init mode. Format is set to None.</summary>
    /// <returns>Returns True if the marquee was successfully stopped; otherwise, False.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryStopScrollingAsync();
  }
}
