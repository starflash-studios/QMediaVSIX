// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorSessionApprovalStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  /// <summary>This API is for internal use only and should not be used in your code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MicrosoftAccountMultiFactorSessionApprovalStatus
  {
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    Pending,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    Approved,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    Denied,
  }
}
