// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisementPublisher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3009031450, 39711, 17881, 146, 90, 105, 77, 102, 223, 104, 239)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisementPublisher))]
  internal interface IWiFiDirectAdvertisementPublisher
  {
    WiFiDirectAdvertisement Advertisement { get; }

    WiFiDirectAdvertisementPublisherStatus Status { get; }

    event TypedEventHandler<WiFiDirectAdvertisementPublisher, WiFiDirectAdvertisementPublisherStatusChangedEventArgs> StatusChanged;

    void Start();

    void Stop();
  }
}
