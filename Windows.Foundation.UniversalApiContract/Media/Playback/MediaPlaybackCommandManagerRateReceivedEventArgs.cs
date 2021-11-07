// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManagerRateReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data or the MediaPlaybackCommandManager.RateReceived event, which occurs when the command manager receives a command changing the current playback rate from the System Media Transport Controls.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackCommandManagerRateReceivedEventArgs : 
    IMediaPlaybackCommandManagerRateReceivedEventArgs
  {
    /// <summary>Gets or sets a value indicating whether the RateReceived event has been handled.</summary>
    /// <returns>True if the event has been handled; otherwise, false.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating the current playback rate.</summary>
    /// <returns>A value indicating the current playback rate.</returns>
    public extern double PlaybackRate { [MethodImpl] get; }

    /// <summary>Gets a Deferral object that causes the system to wait for you to perform asynchronous operations, such as creating a new MediaPlaybackItem from a network source, before it continues processing the change rate command.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
