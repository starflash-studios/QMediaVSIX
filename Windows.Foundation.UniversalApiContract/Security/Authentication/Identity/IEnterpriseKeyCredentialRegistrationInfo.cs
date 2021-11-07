// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.IEnterpriseKeyCredentialRegistrationInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EnterpriseKeyCredentialRegistrationInfo))]
  [Guid(942807756, 26411, 18467, 182, 3, 107, 60, 117, 61, 175, 151)]
  internal interface IEnterpriseKeyCredentialRegistrationInfo
  {
    string TenantId { get; }

    string TenantName { get; }

    string Subject { get; }

    string KeyId { get; }

    string KeyName { get; }
  }
}
