// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ProvisionedProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Updates cost and usage information for a mobile broadband profile.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProvisionedProfile : IProvisionedProfile
  {
    /// <summary>Called by the application to update the cost for a specific profile.</summary>
    /// <param name="value">Updates the cost for the profile.</param>
    [MethodImpl]
    public extern void UpdateCost(NetworkCostType value);

    /// <summary>Called by the application to update the usage for a specific profile.</summary>
    /// <param name="value">Updates the usage for a profile.</param>
    [MethodImpl]
    public extern void UpdateUsage(ProfileUsage value);
  }
}
