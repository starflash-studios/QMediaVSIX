// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.NamedPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Management.Policies
{
  /// <summary>Provides functionality to get Mobile Device Management (MDM) policy information.</summary>
  [Static(typeof (INamedPolicyStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public static class NamedPolicy
  {
    /// <summary>Gets the valid MDM policy information given a specified policy name and area name.</summary>
    /// <param name="area">A string representing the area name for a policy.</param>
    /// <param name="name">A string representing the name of the policy.</param>
    /// <returns>The NamedPolicyData for the policy specified by the area and name parameters.</returns>
    [MethodImpl]
    public static extern NamedPolicyData GetPolicyFromPath(string area, string name);

    /// <summary>Gets a valid MDM user policy given the specified MDM policy name and area name. This is more user friendly than GetPolicyFromPath.</summary>
    /// <param name="user">The user data for user policies.</param>
    /// <param name="area">A string representing the area name for a policy.</param>
    /// <param name="name">A string representing the name of the policy.</param>
    /// <returns>The NamedPolicyData for the policy specified by the user, area, and name parameters.</returns>
    [MethodImpl]
    public static extern NamedPolicyData GetPolicyFromPathForUser(
      User user,
      string area,
      string name);
  }
}
