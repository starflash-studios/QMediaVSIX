// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ContractVersionAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates the version of the API contract.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AllowMultiple]
  [AttributeUsage((AttributeTargets) 3967)]
  public sealed class ContractVersionAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="version">The version of the API contract.</param>
    [MethodImpl]
    public extern ContractVersionAttribute(uint version);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="contract">The type to associate with the API contract.</param>
    /// <param name="version">The version of the API contract.</param>
    [MethodImpl]
    public extern ContractVersionAttribute(Type contract, uint version);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="contract">The type to associate with the API contract.</param>
    /// <param name="version">The version of the API contract.</param>
    [MethodImpl]
    public extern ContractVersionAttribute(string contract, uint version);
  }
}
