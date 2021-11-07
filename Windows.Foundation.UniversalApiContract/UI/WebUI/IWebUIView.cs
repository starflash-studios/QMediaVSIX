// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [Guid(1736701519, 21210, 20439, 190, 105, 142, 246, 40, 75, 66, 60)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (WebUIView))]
  internal interface IWebUIView
  {
    int ApplicationViewId { get; }

    event TypedEventHandler<WebUIView, object> Closed;

    event TypedEventHandler<WebUIView, IActivatedEventArgs> Activated;

    bool IgnoreApplicationContentUriRulesNavigationRestrictions { get; set; }
  }
}
