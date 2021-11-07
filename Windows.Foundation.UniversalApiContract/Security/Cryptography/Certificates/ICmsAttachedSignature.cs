// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsAttachedSignature
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CmsAttachedSignature))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1636408733, 14167, 20171, 189, 220, 12, 163, 87, 215, 169, 54)]
  internal interface ICmsAttachedSignature
  {
    IVectorView<Certificate> Certificates { get; }

    byte[] Content { get; }

    IVectorView<CmsSignerInfo> Signers { get; }

    SignatureValidationResult VerifySignature();
  }
}
