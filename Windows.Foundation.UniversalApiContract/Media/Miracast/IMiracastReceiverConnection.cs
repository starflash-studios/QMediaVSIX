// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ExclusiveTo(typeof (MiracastReceiverConnection))]
  [Guid(1883975478, 53989, 21791, 168, 84, 248, 34, 183, 145, 125, 40)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverConnection
  {
    [Overload("Disconnect")]
    void Disconnect(MiracastReceiverDisconnectReason reason);

    [Overload("DisconnectWithMessage")]
    void Disconnect(MiracastReceiverDisconnectReason reason, string message);

    void Pause();

    [RemoteAsync]
    IAsyncAction PauseAsync();

    void Resume();

    [RemoteAsync]
    IAsyncAction ResumeAsync();

    MiracastTransmitter Transmitter { get; }

    MiracastReceiverInputDevices InputDevices { get; }

    MiracastReceiverCursorImageChannel CursorImageChannel { get; }

    MiracastReceiverStreamControl StreamControl { get; }
  }
}
