// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(2874219053, 10758, 18849, 165, 132, 97, 67, 92, 121, 5, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisement))]
  internal interface IWiFiDirectAdvertisement
  {
    IVector<WiFiDirectInformationElement> InformationElements { get; set; }

    WiFiDirectAdvertisementListenStateDiscoverability ListenStateDiscoverability { get; set; }

    bool IsAutonomousGroupOwnerEnabled { get; set; }

    WiFiDirectLegacySettings LegacySettings { get; }
  }
}
