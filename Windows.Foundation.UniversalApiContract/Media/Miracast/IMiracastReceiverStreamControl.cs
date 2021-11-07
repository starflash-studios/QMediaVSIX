// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverStreamControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ExclusiveTo(typeof (MiracastReceiverStreamControl))]
  [Guid(954871179, 10089, 23255, 138, 138, 37, 75, 157, 247, 186, 130)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverStreamControl
  {
    MiracastReceiverVideoStreamSettings GetVideoStreamSettings();

    [RemoteAsync]
    IAsyncOperation<MiracastReceiverVideoStreamSettings> GetVideoStreamSettingsAsync();

    void SuggestVideoStreamSettings(MiracastReceiverVideoStreamSettings settings);

    [RemoteAsync]
    IAsyncAction SuggestVideoStreamSettingsAsync(
      MiracastReceiverVideoStreamSettings settings);

    bool MuteAudio { get; set; }
  }
}
