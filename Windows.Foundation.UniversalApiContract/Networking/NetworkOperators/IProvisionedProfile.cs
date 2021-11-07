// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IProvisionedProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ProvisionedProfile))]
  [Guid(561447136, 33282, 4575, 173, 185, 244, 206, 70, 45, 145, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProvisionedProfile
  {
    void UpdateCost(NetworkCostType value);

    void UpdateUsage(ProfileUsage value);
  }
}
