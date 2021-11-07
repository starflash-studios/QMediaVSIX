// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountProviderCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (WebAccountProviderCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3600539034, 41126, 20123, 136, 220, 199, 30, 117, 122, 53, 1)]
  internal interface IWebAccountProviderCommand
  {
    WebAccountProvider WebAccountProvider { get; }

    WebAccountProviderCommandInvokedHandler Invoked { get; }
  }
}
