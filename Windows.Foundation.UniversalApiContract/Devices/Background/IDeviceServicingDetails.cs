// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Background.IDeviceServicingDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Background
{
  [Guid(1252781609, 9028, 19140, 133, 39, 74, 142, 246, 144, 86, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceServicingDetails))]
  internal interface IDeviceServicingDetails
  {
    string DeviceId { get; }

    string Arguments { get; }

    TimeSpan ExpectedDuration { get; }
  }
}
