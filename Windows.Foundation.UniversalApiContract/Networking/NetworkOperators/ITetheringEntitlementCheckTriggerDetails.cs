// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ITetheringEntitlementCheckTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(63331997, 22822, 16883, 169, 78, 181, 9, 38, 252, 66, 27)]
  [ExclusiveTo(typeof (TetheringEntitlementCheckTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ITetheringEntitlementCheckTriggerDetails
  {
    string NetworkAccountId { get; }

    void AllowTethering();

    void DenyTethering(string entitlementFailureReason);
  }
}
