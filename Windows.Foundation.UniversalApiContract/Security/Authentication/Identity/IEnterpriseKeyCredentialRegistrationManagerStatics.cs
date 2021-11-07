// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.IEnterpriseKeyCredentialRegistrationManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [ExclusiveTo(typeof (EnterpriseKeyCredentialRegistrationManager))]
  [Guid(2008571550, 44276, 19392, 186, 194, 64, 187, 70, 239, 187, 63)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEnterpriseKeyCredentialRegistrationManagerStatics
  {
    EnterpriseKeyCredentialRegistrationManager Current { get; }
  }
}
