// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1529041938, 13808, 18919, 155, 8, 22, 210, 120, 251, 170, 66)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  internal interface INetworkOperatorTetheringManagerStatics2
  {
    TetheringCapability GetTetheringCapabilityFromConnectionProfile(
      ConnectionProfile profile);

    [Overload("CreateFromConnectionProfile")]
    NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile);
  }
}
