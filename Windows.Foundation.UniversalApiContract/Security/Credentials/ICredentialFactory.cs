// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.ICredentialFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(1424954273, 48934, 18357, 151, 221, 222, 119, 155, 124, 173, 88)]
  [ExclusiveTo(typeof (PasswordCredential))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICredentialFactory
  {
    PasswordCredential CreatePasswordCredential(
      string resource,
      string userName,
      string password);
  }
}
