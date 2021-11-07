// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectInformationElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect
{
  [Guid(3687853846, 4517, 20064, 140, 170, 52, 119, 33, 72, 55, 138)]
  [ExclusiveTo(typeof (WiFiDirectInformationElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectInformationElementStatics
  {
    IVector<WiFiDirectInformationElement> CreateFromBuffer(
      IBuffer buffer);

    IVector<WiFiDirectInformationElement> CreateFromDeviceInformation(
      DeviceInformation deviceInformation);
  }
}
