// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [Guid(2050052696, 58436, 20916, 175, 247, 184, 141, 170, 18, 41, 224)]
  [ExclusiveTo(typeof (MiracastReceiver))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiver
  {
    MiracastReceiverSettings GetDefaultSettings();

    MiracastReceiverSettings GetCurrentSettings();

    [RemoteAsync]
    IAsyncOperation<MiracastReceiverSettings> GetCurrentSettingsAsync();

    MiracastReceiverApplySettingsResult DisconnectAllAndApplySettings(
      MiracastReceiverSettings settings);

    [RemoteAsync]
    IAsyncOperation<MiracastReceiverApplySettingsResult> DisconnectAllAndApplySettingsAsync(
      MiracastReceiverSettings settings);

    MiracastReceiverStatus GetStatus();

    [RemoteAsync]
    IAsyncOperation<MiracastReceiverStatus> GetStatusAsync();

    event TypedEventHandler<MiracastReceiver, object> StatusChanged;

    MiracastReceiverSession CreateSession(CoreApplicationView view);

    [RemoteAsync]
    IAsyncOperation<MiracastReceiverSession> CreateSessionAsync(
      CoreApplicationView view);

    void ClearKnownTransmitters();

    void RemoveKnownTransmitter(MiracastTransmitter transmitter);
  }
}
