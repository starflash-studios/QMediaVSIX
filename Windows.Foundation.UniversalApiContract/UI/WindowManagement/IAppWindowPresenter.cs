// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AppWindowPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1525280115, 57853, 21271, 173, 120, 90, 62, 210, 113, 187, 222)]
  internal interface IAppWindowPresenter
  {
    AppWindowPresentationConfiguration GetConfiguration();

    bool IsPresentationSupported(AppWindowPresentationKind presentationKind);

    [Overload("RequestPresentation")]
    bool RequestPresentation(AppWindowPresentationConfiguration configuration);

    [Overload("RequestPresentationByKind")]
    [DefaultOverload]
    bool RequestPresentation(AppWindowPresentationKind presentationKind);
  }
}
