// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  /// <summary>Possible results when access to protected content is requested or queried.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ProtectionPolicyEvaluationResult
  {
    /// <summary>Access is allowed.</summary>
    Allowed,
    /// <summary>Access is blocked.</summary>
    Blocked,
    /// <summary>Consent is required for access.</summary>
    ConsentRequired,
  }
}
