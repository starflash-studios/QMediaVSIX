// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetwork
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandNetwork))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3412300428, 777, 19638, 168, 193, 106, 90, 60, 142, 31, 246)]
  internal interface IMobileBroadbandNetwork
  {
    NetworkAdapter NetworkAdapter { get; }

    NetworkRegistrationState NetworkRegistrationState { get; }

    uint RegistrationNetworkError { get; }

    uint PacketAttachNetworkError { get; }

    uint ActivationNetworkError { get; }

    string AccessPointName { get; }

    DataClasses RegisteredDataClass { get; }

    string RegisteredProviderId { get; }

    string RegisteredProviderName { get; }

    void ShowConnectionUI();
  }
}
