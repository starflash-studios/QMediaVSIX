// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectInformationElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectInformationElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2952491734, 30395, 18814, 172, 139, 220, 114, 131, 139, 195, 9)]
  internal interface IWiFiDirectInformationElement
  {
    IBuffer Oui { get; set; }

    byte OuiType { get; set; }

    IBuffer Value { get; set; }
  }
}
