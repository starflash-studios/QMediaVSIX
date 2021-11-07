// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailIrmInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailIrmInfo))]
  [Guid(2431984019, 45472, 20157, 166, 182, 221, 202, 85, 96, 110, 14)]
  internal interface IEmailIrmInfo
  {
    bool CanEdit { get; set; }

    bool CanExtractData { get; set; }

    bool CanForward { get; set; }

    bool CanModifyRecipientsOnResponse { get; set; }

    bool CanPrintData { get; set; }

    bool CanRemoveIrmOnResponse { get; set; }

    bool CanReply { get; set; }

    bool CanReplyAll { get; set; }

    DateTime ExpirationDate { get; set; }

    bool IsIrmOriginator { get; set; }

    bool IsProgramaticAccessAllowed { get; set; }

    EmailIrmTemplate Template { get; set; }
  }
}
