// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBluetoothLEAdvertisementPublisherTrigger2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2854801508, 14580, 22909, 181, 151, 78, 85, 88, 140, 101, 3)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisherTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IBluetoothLEAdvertisementPublisherTrigger2
  {
    IReference<short> PreferredTransmitPowerLevelInDBm { get; set; }

    bool UseExtendedFormat { get; set; }

    bool IsAnonymous { get; set; }

    bool IncludeTransmitPowerLevel { get; set; }
  }
}
