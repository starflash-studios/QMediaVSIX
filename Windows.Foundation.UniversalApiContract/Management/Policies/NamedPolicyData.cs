// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.NamedPolicyData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Management.Policies
{
  /// <summary>Policy data information for mobile device management.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NamedPolicyData : INamedPolicyData
  {
    /// <summary>Gets the MDM policy area name.</summary>
    /// <returns>The MDM policy area name.</returns>
    public extern string Area { [MethodImpl] get; }

    /// <summary>Gets the MDM policy name value.</summary>
    /// <returns>The MDM policy name value.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the type of the MDM policy value.</summary>
    /// <returns>The type of the named MDM policy from the NamedPolicyKind enumeration.</returns>
    public extern NamedPolicyKind Kind { [MethodImpl] get; }

    /// <summary>Determines whether an MDM policy is actively managed or not.</summary>
    /// <returns>True if the policy is managed; False if the policy is not managed.</returns>
    public extern bool IsManaged { [MethodImpl] get; }

    /// <summary>Determines whether an MDM policy is a user policy or not.</summary>
    /// <returns>True if the policy is a user policy; False if the policy is not a user policy.</returns>
    public extern bool IsUserPolicy { [MethodImpl] get; }

    /// <summary>Gets the user's data for the MDM user policy.</summary>
    /// <returns>Windows.System.User associated with the user policy.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the boolean representation of the MDM policy value.</summary>
    /// <returns>The boolean value of the MDM policy.</returns>
    [MethodImpl]
    public extern bool GetBoolean();

    /// <summary>Gets the binary representation of the MDM policy value.</summary>
    /// <returns>IBuffer containing the binary value of the MDM policy.</returns>
    [MethodImpl]
    public extern IBuffer GetBinary();

    /// <summary>Gets the 32 bit integer representation of the MDM policy value.</summary>
    /// <returns>The 32 bit integer value of the MDM policy.</returns>
    [MethodImpl]
    public extern int GetInt32();

    /// <summary>Gets the 64 bit integer representation of the MDM policy value.</summary>
    /// <returns>The 64 bit integer value of the MDM policy.</returns>
    [MethodImpl]
    public extern long GetInt64();

    /// <summary>Gets the string representation of the MDM policy value.</summary>
    /// <returns>The string value of the MDM policy.</returns>
    [MethodImpl]
    public extern string GetString();

    /// <summary>Occurs when the MDM policy is changed.</summary>
    public extern event TypedEventHandler<NamedPolicyData, object> Changed;
  }
}
