// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipientResolutionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2441296122, 36237, 17779, 128, 209, 7, 23, 42, 52, 185, 141)]
  [ExclusiveTo(typeof (EmailRecipientResolutionResult))]
  internal interface IEmailRecipientResolutionResult
  {
    EmailRecipientResolutionStatus Status { get; }

    IVectorView<Certificate> PublicKeys { get; }
  }
}
