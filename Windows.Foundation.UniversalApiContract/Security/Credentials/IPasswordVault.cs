// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IPasswordVault
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (PasswordVault))]
  [Guid(1643981835, 51412, 18625, 165, 79, 188, 90, 100, 32, 90, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPasswordVault
  {
    void Add(PasswordCredential credential);

    void Remove(PasswordCredential credential);

    PasswordCredential Retrieve(string resource, string userName);

    IVectorView<PasswordCredential> FindAllByResource(string resource);

    IVectorView<PasswordCredential> FindAllByUserName(string userName);

    IVectorView<PasswordCredential> RetrieveAll();
  }
}
