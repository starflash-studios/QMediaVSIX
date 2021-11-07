// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.ICredentialPickerResults
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  [ExclusiveTo(typeof (CredentialPickerResults))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(424212890, 52272, 16652, 156, 56, 204, 8, 132, 197, 179, 215)]
  internal interface ICredentialPickerResults
  {
    uint ErrorCode { get; }

    CredentialSaveOption CredentialSaveOption { get; }

    bool CredentialSaved { get; }

    IBuffer Credential { get; }

    string CredentialDomainName { get; }

    string CredentialUserName { get; }

    string CredentialPassword { get; }
  }
}
