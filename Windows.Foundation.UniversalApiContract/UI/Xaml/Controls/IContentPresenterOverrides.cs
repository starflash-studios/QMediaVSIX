// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2808297965, 13055, 17291, 170, 213, 29, 104, 250, 233, 52, 38)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentPresenter))]
  internal interface IContentPresenterOverrides
  {
    void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);

    void OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);
  }
}
