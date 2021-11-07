// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4114056897, 21089, 19677, 151, 109, 204, 144, 154, 199, 22, 32)]
  [ExclusiveTo(typeof (KeyCredentialOperationResult))]
  internal interface IKeyCredentialOperationResult
  {
    IBuffer Result { get; }

    KeyCredentialStatus Status { get; }
  }
}
