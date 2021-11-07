// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.CreateFromStringAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Create from string attribute.</summary>
  [AttributeName("createfromstring")]
  [WebHostHidden]
  [AttributeUsage(AttributeTargets.RuntimeClass | AttributeTargets.Struct)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class CreateFromStringAttribute : Attribute
  {
    /// <summary>
    /// </summary>
    public string MethodName;

    /// <summary>Create from string attribute.</summary>
    [MethodImpl]
    public extern CreateFromStringAttribute();
  }
}
