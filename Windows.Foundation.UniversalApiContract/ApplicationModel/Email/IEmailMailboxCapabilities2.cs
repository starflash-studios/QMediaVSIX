// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCapabilities2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1769094884, 12065, 19644, 136, 171, 46, 118, 2, 164, 128, 107)]
  [ExclusiveTo(typeof (EmailMailboxCapabilities))]
  internal interface IEmailMailboxCapabilities2
  {
    bool CanResolveRecipients { get; }

    bool CanValidateCertificates { get; }

    bool CanEmptyFolder { get; }

    bool CanCreateFolder { get; }

    bool CanDeleteFolder { get; }

    bool CanMoveFolder { get; }
  }
}
