// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESim2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3176124576, 50831, 22251, 185, 155, 143, 52, 184, 16, 2, 153)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (ESim))]
  internal interface IESim2
  {
    [Overload("Discover")]
    ESimDiscoverResult Discover();

    [Overload("DiscoverWithServerAddressAndMatchingId")]
    ESimDiscoverResult Discover(string serverAddress, string matchingId);

    [RemoteAsync]
    [Overload("DiscoverAsync")]
    IAsyncOperation<ESimDiscoverResult> DiscoverAsync();

    [RemoteAsync]
    [Overload("DiscoverWithServerAddressAndMatchingIdAsync")]
    IAsyncOperation<ESimDiscoverResult> DiscoverAsync(
      string serverAddress,
      string matchingId);
  }
}
