// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBaseStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2182873288, 30924, 16671, 159, 46, 165, 87, 88, 34, 127, 62)]
  [ExclusiveTo(typeof (ListViewBase))]
  internal interface IListViewBaseStatics2
  {
    DependencyProperty ShowsScrollingPlaceholdersProperty { get; }

    DependencyProperty FooterProperty { get; }

    DependencyProperty FooterTemplateProperty { get; }

    DependencyProperty FooterTransitionsProperty { get; }
  }
}
