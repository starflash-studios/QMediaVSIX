// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkStateChangeEventDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(520942387, 55206, 17629, 164, 233, 104, 124, 71, 107, 144, 61)]
  [ExclusiveTo(typeof (NetworkStateChangeEventDetails))]
  internal interface INetworkStateChangeEventDetails
  {
    bool HasNewInternetConnectionProfile { get; }

    bool HasNewConnectionCost { get; }

    bool HasNewNetworkConnectivityLevel { get; }

    bool HasNewDomainConnectivityLevel { get; }

    bool HasNewHostNameList { get; }

    bool HasNewWwanRegistrationState { get; }
  }
}
