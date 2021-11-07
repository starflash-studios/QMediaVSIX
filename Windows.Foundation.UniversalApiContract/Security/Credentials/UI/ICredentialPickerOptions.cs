// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.ICredentialPickerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials.UI
{
  [Guid(2522483532, 38394, 18047, 153, 43, 11, 34, 229, 133, 155, 246)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CredentialPickerOptions))]
  internal interface ICredentialPickerOptions
  {
    string Caption { set; get; }

    string Message { set; get; }

    uint ErrorCode { set; get; }

    string TargetName { set; get; }

    AuthenticationProtocol AuthenticationProtocol { set; get; }

    string CustomAuthenticationProtocol { set; get; }

    IBuffer PreviousCredential { set; get; }

    bool AlwaysDisplayDialog { set; get; }

    bool CallerSavesCredential { set; get; }

    CredentialSaveOption CredentialSaveOption { set; get; }
  }
}
