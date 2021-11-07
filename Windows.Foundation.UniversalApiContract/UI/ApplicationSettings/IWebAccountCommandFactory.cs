// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountCommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (WebAccountCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3215379967, 12077, 17141, 129, 222, 29, 86, 186, 252, 73, 109)]
  internal interface IWebAccountCommandFactory
  {
    WebAccountCommand CreateWebAccountCommand(
      WebAccount webAccount,
      WebAccountCommandInvokedHandler invoked,
      SupportedWebAccountActions actions);
  }
}
