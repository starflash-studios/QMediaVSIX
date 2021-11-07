// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ExperimentalAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates that a type or member should be marked in metadata as experimental, and consequently may not be present in the final, released version of an SDK or library.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.RuntimeClass | AttributeTargets.Struct)]
  public sealed class ExperimentalAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    [MethodImpl]
    public extern ExperimentalAttribute();
  }
}
