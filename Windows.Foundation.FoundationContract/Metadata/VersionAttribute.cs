// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.VersionAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates the version of the type.</summary>
  [AllowMultiple]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage((AttributeTargets) 3967)]
  public sealed class VersionAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="version">The version to associate with the marked object.</param>
    [MethodImpl]
    public extern VersionAttribute(uint version);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="version">The version to associate with the marked object.</param>
    /// <param name="platform">A value of the enumeration. The default is **Windows**.</param>
    [MethodImpl]
    public extern VersionAttribute(uint version, Platform platform);
  }
}
