// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceConnectionChangeTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2424790628, 15581, 20219, 171, 28, 91, 59, 106, 96, 206, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceConnectionChangeTrigger))]
  internal interface IDeviceConnectionChangeTrigger : IBackgroundTrigger
  {
    string DeviceId { get; }

    bool CanMaintainConnection { get; }

    bool MaintainConnection { get; set; }
  }
}
