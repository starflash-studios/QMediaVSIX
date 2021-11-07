// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenRequest3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebProviderTokenRequest))]
  [Guid(455546538, 17033, 17518, 146, 86, 218, 251, 111, 102, 165, 30)]
  internal interface IWebProviderTokenRequest3
  {
    string ApplicationPackageFamilyName { get; }

    string ApplicationProcessName { get; }

    [RemoteAsync]
    IAsyncOperation<bool> CheckApplicationForCapabilityAsync(string capabilityName);
  }
}
