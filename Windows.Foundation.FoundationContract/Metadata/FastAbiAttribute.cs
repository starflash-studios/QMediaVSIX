// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.FastAbiAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates if the type supports fast ABI.</summary>
  [ContractVersion(typeof (FoundationContract), 262144)]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class FastAbiAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="version">The ABI version number.</param>
    [MethodImpl]
    public extern FastAbiAttribute(uint version);

    /// <summary>
    /// </summary>
    /// <param name="version">The ABI version number.</param>
    /// <param name="platform">The ABI platform name.</param>
    [MethodImpl]
    public extern FastAbiAttribute(uint version, Platform platform);

    /// <summary>
    /// </summary>
    /// <param name="version">The ABI version number.</param>
    /// <param name="contractName">The ABI contractName.</param>
    [MethodImpl]
    public extern FastAbiAttribute(uint version, string contractName);
  }
}
