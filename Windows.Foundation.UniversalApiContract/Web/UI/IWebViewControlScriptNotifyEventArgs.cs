// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlScriptNotifyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [Guid(1226696059, 28489, 16827, 181, 145, 81, 184, 91, 129, 112, 55)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebViewControlScriptNotifyEventArgs))]
  internal interface IWebViewControlScriptNotifyEventArgs
  {
    Uri Uri { get; }

    string Value { get; }
  }
}
