// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectConnectionRequest))]
  [Guid(2394527237, 37199, 18883, 166, 20, 209, 141, 197, 177, 155, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectConnectionRequest : IClosable
  {
    DeviceInformation DeviceInformation { get; }
  }
}
