// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerFinderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [Guid(3605478501, 64976, 19211, 147, 18, 134, 100, 8, 147, 93, 130)]
  [ExclusiveTo(typeof (PeerFinder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPeerFinderStatics2
  {
    PeerRole Role { get; set; }

    IBuffer DiscoveryData { get; set; }

    PeerWatcher CreateWatcher();
  }
}
