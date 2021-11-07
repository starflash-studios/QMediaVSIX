// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.PreviousContractVersionAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates that the type was previously associated with a different API contract.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage((AttributeTargets) 3967)]
  [AllowMultiple]
  public sealed class PreviousContractVersionAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="contract">The name of the previous contract.</param>
    /// <param name="versionLow">The first version of the previous contract to which the type was associated.</param>
    /// <param name="versionHigh">The last version of the previous contract to which the type was associated.</param>
    /// <param name="newContract">The name of the new contract to which the type is associated.</param>
    [MethodImpl]
    public extern PreviousContractVersionAttribute(
      string contract,
      uint versionLow,
      uint versionHigh,
      string newContract);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="contract">The name of the previous contract.</param>
    /// <param name="versionLow">The first version of the previous contract to which the type was associated.</param>
    /// <param name="versionHigh">The last version of the previous contract to which the type was associated.</param>
    [MethodImpl]
    public extern PreviousContractVersionAttribute(
      string contract,
      uint versionLow,
      uint versionHigh);
  }
}
