// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerInformation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PeerInformation))]
  [Guid(2987352362, 56272, 16632, 149, 189, 45, 66, 9, 199, 131, 111)]
  internal interface IPeerInformation3
  {
    string Id { get; }

    IBuffer DiscoveryData { get; }
  }
}
