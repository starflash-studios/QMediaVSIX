// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.LicenseSatisfactionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  /// <summary>Contains license entitlement info for a product.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class LicenseSatisfactionInfo : ILicenseSatisfactionInfo
  {
    /// <summary>Gets a value that indicates whether the license entitlement is associated with the current device.</summary>
    /// <returns>True if the license entitlement is associated with the current device; otherwise, false.</returns>
    public extern bool SatisfiedByDevice { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license entitlement is associated with an open license.</summary>
    /// <returns>True if the license entitlement is associated with an open license; otherwise, false.</returns>
    public extern bool SatisfiedByOpenLicense { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license entitlement is associated with a trial.</summary>
    /// <returns>True if the license entitlement is associated with a trial; otherwise, false.</returns>
    public extern bool SatisfiedByTrial { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license entitlement is associated with a pass.</summary>
    /// <returns>True if the license entitlement is associated with a pass; otherwise, false.</returns>
    public extern bool SatisfiedByPass { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license entitlement is associated with installation media.</summary>
    /// <returns>True if the license entitlement is associated with installation media; otherwise, false.</returns>
    public extern bool SatisfiedByInstallMedia { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the license entitlement is associated with the current signed in user.</summary>
    /// <returns>True if the license entitlement is associated with the current signed in user; otherwise, false.</returns>
    public extern bool SatisfiedBySignedInUser { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether a license entitlement exists for the product.</summary>
    /// <returns>True if a license entitlement exists for the product; otherwise, false.</returns>
    public extern bool IsSatisfied { [MethodImpl] get; }
  }
}
