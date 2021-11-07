// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletRelevantLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2681763882, 58361, 19937, 186, 179, 187, 25, 46, 70, 179, 243)]
  [ExclusiveTo(typeof (WalletRelevantLocation))]
  internal interface IWalletRelevantLocation
  {
    BasicGeoposition Position { get; set; }

    string DisplayMessage { get; set; }
  }
}
