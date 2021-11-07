// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisementPublisherStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(2868766012, 21633, 18150, 144, 221, 50, 17, 101, 24, 241, 146)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisementPublisherStatusChangedEventArgs))]
  internal interface IWiFiDirectAdvertisementPublisherStatusChangedEventArgs
  {
    WiFiDirectAdvertisementPublisherStatus Status { get; }

    WiFiDirectError Error { get; }
  }
}
