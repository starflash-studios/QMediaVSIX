// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistration))]
  [Guid(2672606132, 36026, 18608, 132, 13, 219, 178, 42, 84, 198, 120)]
  internal interface ISecondaryAuthenticationFactorRegistration
  {
    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction FinishRegisteringDeviceAsync(IBuffer deviceConfigurationData);

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction AbortRegisteringDeviceAsync(string errorLogMessage);
  }
}
