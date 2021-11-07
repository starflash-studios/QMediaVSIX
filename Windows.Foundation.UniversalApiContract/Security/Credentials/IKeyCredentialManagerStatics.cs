// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (KeyCredentialManager))]
  [Guid(1789675147, 3825, 19680, 130, 144, 65, 6, 218, 106, 99, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyCredentialManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsSupportedAsync();

    [RemoteAsync]
    IAsyncAction RenewAttestationAsync();

    IAsyncOperation<KeyCredentialRetrievalResult> RequestCreateAsync(
      string name,
      KeyCredentialCreationOption option);

    [RemoteAsync]
    IAsyncOperation<KeyCredentialRetrievalResult> OpenAsync(
      string name);

    [RemoteAsync]
    IAsyncAction DeleteAsync(string name);
  }
}
