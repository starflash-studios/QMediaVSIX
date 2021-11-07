// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSessionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceSessionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2699197579, 20683, 19032, 155, 207, 228, 114, 185, 159, 186, 4)]
  internal interface IWiFiDirectServiceSessionRequest : IClosable
  {
    DeviceInformation DeviceInformation { get; }

    WiFiDirectServiceProvisioningInfo ProvisioningInfo { get; }

    IBuffer SessionInfo { get; }
  }
}
