// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.IEnterpriseKeyCredentialRegistrationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [Guid(2213789247, 41567, 19642, 187, 142, 189, 195, 45, 3, 194, 151)]
  [ExclusiveTo(typeof (EnterpriseKeyCredentialRegistrationManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEnterpriseKeyCredentialRegistrationManager
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<EnterpriseKeyCredentialRegistrationInfo>> GetRegistrationsAsync();
  }
}
