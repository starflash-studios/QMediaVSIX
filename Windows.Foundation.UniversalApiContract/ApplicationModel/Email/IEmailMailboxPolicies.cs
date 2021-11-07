// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxPolicies
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxPolicies))]
  [Guid(523453893, 7227, 19911, 180, 16, 99, 115, 120, 62, 84, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxPolicies
  {
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation AllowedSmimeEncryptionAlgorithmNegotiation { get; }

    bool AllowSmimeSoftCertificates { get; }

    IReference<EmailMailboxSmimeEncryptionAlgorithm> RequiredSmimeEncryptionAlgorithm { get; }

    IReference<EmailMailboxSmimeSigningAlgorithm> RequiredSmimeSigningAlgorithm { get; }
  }
}
