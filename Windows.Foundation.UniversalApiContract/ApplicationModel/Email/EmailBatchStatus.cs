// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailBatchStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the states of an email batch operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailBatchStatus
  {
    /// <summary>The batch operation has completed successfully.</summary>
    Success,
    /// <summary>The batch operation has failed due to a sync manager error.</summary>
    ServerSearchSyncManagerError,
    /// <summary>The batch operation has failed due to an unknown error.</summary>
    ServerSearchUnknownError,
  }
}
