// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3399717784, 40186, 16966, 176, 196, 169, 19, 163, 137, 101, 65)]
  [ExclusiveTo(typeof (WebAccountCommand))]
  internal interface IWebAccountCommand
  {
    WebAccount WebAccount { get; }

    WebAccountCommandInvokedHandler Invoked { get; }

    SupportedWebAccountActions Actions { get; }
  }
}
