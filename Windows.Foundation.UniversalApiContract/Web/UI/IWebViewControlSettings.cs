// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [Guid(3382083519, 24216, 19709, 140, 206, 39, 176, 145, 30, 61, 232)]
  [ExclusiveTo(typeof (WebViewControlSettings))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IWebViewControlSettings
  {
    bool IsJavaScriptEnabled { set; get; }

    bool IsIndexedDBEnabled { set; get; }

    bool IsScriptNotifyAllowed { set; get; }
  }
}
