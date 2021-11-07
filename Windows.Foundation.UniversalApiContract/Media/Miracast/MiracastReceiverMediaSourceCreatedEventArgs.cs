// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Miracast
{
  /// <summary>Provides data for the MiracastReceiverSession.MediaSourceCreated event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverMediaSourceCreatedEventArgs : 
    IMiracastReceiverMediaSourceCreatedEventArgs
  {
    /// <summary>Returns the MiracastReceiverConnection object of the associated connection.</summary>
    /// <returns>The MiracastReceiverConnection object.</returns>
    public extern MiracastReceiverConnection Connection { [MethodImpl] get; }

    /// <summary>Returns a MediaSource object for playing the audio and video data that is being sent by the Miracast Transmitter.</summary>
    /// <returns>The MediaSource object.</returns>
    public extern MediaSource MediaSource { [MethodImpl] get; }

    /// <summary>Returns an object for configuring the settings of the optional cursor image channel.</summary>
    /// <returns>The MiracastReceiverCursorImageChannelSettings object.</returns>
    public extern MiracastReceiverCursorImageChannelSettings CursorImageChannelSettings { [MethodImpl] get; }

    /// <summary>Defers completion of the MiracastReceiverSession.MediaSourceCreated event until Deferral.Complete is invoked.</summary>
    /// <returns>The Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
