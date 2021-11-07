// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerInformationWithHostAndService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [Guid(3972517037, 7024, 20107, 146, 219, 187, 231, 129, 65, 147, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PeerInformation))]
  internal interface IPeerInformationWithHostAndService
  {
    HostName HostName { get; }

    string ServiceName { get; }
  }
}
