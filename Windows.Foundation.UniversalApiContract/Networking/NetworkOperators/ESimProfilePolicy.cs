// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfilePolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that represents the policy for an eSIM profile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ESimProfilePolicy : IESimProfilePolicy
  {
    /// <summary>Gets a value indicating whether the eSIM profile policy represented by this object instance allows the profile to be deleted.</summary>
    /// <returns>`true` if the policy allows the profile to be deleted, otherwise `false`.</returns>
    public extern bool CanDelete { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the eSIM profile policy represented by this object instance allows the profile to be disabled.</summary>
    /// <returns>`true` if the policy allows the profile to be disabled, otherwise `false`.</returns>
    public extern bool CanDisable { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the eSIM profile policy represented by this object instance calls for the profile to be managed by the enterprise.</summary>
    /// <returns>`true` if the policy calls for the profile to be managed by the enterprise, otherwise `false`.</returns>
    public extern bool IsManagedByEnterprise { [MethodImpl] get; }
  }
}
