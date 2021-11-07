// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data or the MediaPlaybackCommandManager.FastForwardReceived event, which occurs when the command manager receives a command from the **Fast-forward** button of the System Media Transport Controls.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlaybackCommandManagerFastForwardReceivedEventArgs : 
    IMediaPlaybackCommandManagerFastForwardReceivedEventArgs
  {
    /// <summary>Gets or sets a value indicating whether the FastForwardReceived event has been handled.</summary>
    /// <returns>True if the event has been handled; otherwise, false.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Deferral object that causes the system to wait for you to perform asynchronous operations, such as creating a new MediaPlaybackItem from a network source, before it continues processing the **Fast-forward** command.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
