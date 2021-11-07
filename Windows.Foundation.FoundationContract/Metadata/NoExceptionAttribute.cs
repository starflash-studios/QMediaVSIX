// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.NoExceptionAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates if the type raises exceptions.</summary>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
  [AttributeName("noexcept")]
  [ContractVersion(typeof (FoundationContract), 262144)]
  public sealed class NoExceptionAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    [MethodImpl]
    public extern NoExceptionAttribute();
  }
}
