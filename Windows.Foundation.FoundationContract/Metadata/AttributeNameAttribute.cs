// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.AttributeNameAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates the name of the attribute</summary>
  [ContractVersion(typeof (FoundationContract), 262144)]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class AttributeNameAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="A_0">One or more of the enumeration values.</param>
    [MethodImpl]
    public extern AttributeNameAttribute(string A_0);
  }
}
