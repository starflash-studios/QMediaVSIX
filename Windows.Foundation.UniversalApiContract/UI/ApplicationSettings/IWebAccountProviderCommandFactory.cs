// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountProviderCommandFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3580201499, 45430, 18294, 132, 105, 169, 211, 255, 11, 63, 89)]
  [ExclusiveTo(typeof (WebAccountProviderCommand))]
  internal interface IWebAccountProviderCommandFactory
  {
    WebAccountProviderCommand CreateWebAccountProviderCommand(
      WebAccountProvider webAccountProvider,
      WebAccountProviderCommandInvokedHandler invoked);
  }
}
