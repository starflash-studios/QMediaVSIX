// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialRetrievalResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyCredentialRetrievalResult))]
  [Guid(1489860355, 36231, 16969, 155, 88, 246, 89, 140, 201, 100, 78)]
  internal interface IKeyCredentialRetrievalResult
  {
    KeyCredential Credential { get; }

    KeyCredentialStatus Status { get; }
  }
}
