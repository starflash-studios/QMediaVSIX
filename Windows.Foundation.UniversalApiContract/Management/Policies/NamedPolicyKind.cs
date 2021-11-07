// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.NamedPolicyKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Policies
{
  /// <summary>Possible data types representing the MDM policy value.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum NamedPolicyKind
  {
    /// <summary>The policy is invalid.</summary>
    Invalid,
    /// <summary>The policy is represented by a binary.</summary>
    Binary,
    /// <summary>The policy is represented by a boolean.</summary>
    Boolean,
    /// <summary>The policy is represented by a 32 bit integer.</summary>
    Int32,
    /// <summary>The policy is represented by a 64 bit integer.</summary>
    Int64,
    /// <summary>The policy is represented by a string.</summary>
    String,
  }
}
