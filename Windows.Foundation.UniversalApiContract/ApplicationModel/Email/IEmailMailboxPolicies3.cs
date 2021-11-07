// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxPolicies3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxPolicies))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3184828447, 18535, 16714, 129, 162, 128, 57, 25, 196, 65, 145)]
  internal interface IEmailMailboxPolicies3
  {
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation AllowedSmimeEncryptionAlgorithmNegotiation { set; }

    bool AllowSmimeSoftCertificates { set; }

    IReference<EmailMailboxSmimeEncryptionAlgorithm> RequiredSmimeEncryptionAlgorithm { set; }

    IReference<EmailMailboxSmimeSigningAlgorithm> RequiredSmimeSigningAlgorithm { set; }

    bool MustEncryptSmimeMessages { set; }

    bool MustSignSmimeMessages { set; }
  }
}
