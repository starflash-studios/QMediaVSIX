// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(3076106822, 55318, 18715, 145, 122, 180, 13, 125, 196, 3, 162)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisement))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IWiFiDirectAdvertisement2
  {
    IVector<WiFiDirectConfigurationMethod> SupportedConfigurationMethods { get; }
  }
}
