// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipientResolutionResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [Guid(1581386678, 52827, 19422, 185, 212, 225, 109, 160, 176, 159, 202)]
  [ExclusiveTo(typeof (EmailRecipientResolutionResult))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailRecipientResolutionResult2
  {
    EmailRecipientResolutionStatus Status { set; }

    void SetPublicKeys(IIterable<Certificate> value);
  }
}
