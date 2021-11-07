// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkStateChangeEventDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (NetworkStateChangeEventDetails))]
  [Guid(3594764520, 12499, 20330, 173, 71, 106, 24, 115, 206, 179, 193)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkStateChangeEventDetails2
  {
    bool HasNewTetheringOperationalState { get; }

    bool HasNewTetheringClientCount { get; }
  }
}
