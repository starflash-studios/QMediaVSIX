// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.AllowForWebAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Enables developers to expose a native Universal Windows Platform (UWP) object as a global parameter in the context of the top-level document inside of a WebView. For a Universal Windows Platform (UWP) object to be projected, it must implement IAgileObject and be decorated with the AllowForWebAttribute attribute.</summary>
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeName("allowforweb")]
  public sealed class AllowForWebAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    [MethodImpl]
    public extern AllowForWebAttribute();
  }
}
