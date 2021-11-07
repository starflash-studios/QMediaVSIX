// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceProvisioningInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceProvisioningInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2346417406, 38873, 17826, 142, 153, 219, 80, 145, 15, 182, 166)]
  internal interface IWiFiDirectServiceProvisioningInfo
  {
    WiFiDirectServiceConfigurationMethod SelectedConfigurationMethod { get; }

    bool IsGroupFormationNeeded { get; }
  }
}
