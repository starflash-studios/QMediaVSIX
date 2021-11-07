// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.PlatformAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Declares the platform that a type should be supported in, when platform-specific metadata is produced.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class PlatformAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="platform">A value of the enumeration. The default is **Windows**.</param>
    [MethodImpl]
    public extern PlatformAttribute(Platform platform);
  }
}
