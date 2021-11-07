// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletRelevantLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents relevant location data for a wallet item. A WalletRelevantLocation object represents the individual items for the WalletItem.RelevantLocations property.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WalletRelevantLocation : IWalletRelevantLocation
  {
    /// <summary>Initializes a new instance of the WalletRelevantLocation class.</summary>
    [MethodImpl]
    public extern WalletRelevantLocation();

    /// <summary>Gets or sets the basic geographic position information of the location.</summary>
    /// <returns>The basic geographic position of the location. BasicGeoposition is a structure, so use field syntax to set the **Latitude** and **Longitude** data.</returns>
    public extern BasicGeoposition Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the message associated with a relevant location.</summary>
    /// <returns>The message associated with a relevant location.</returns>
    public extern string DisplayMessage { [MethodImpl] get; [MethodImpl] set; }
  }
}
