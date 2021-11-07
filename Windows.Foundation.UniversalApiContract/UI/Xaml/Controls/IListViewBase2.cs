// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ListViewBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3519194359, 30883, 17553, 134, 224, 45, 222, 188, 0, 122, 197)]
  internal interface IListViewBase2
  {
    bool ShowsScrollingPlaceholders { get; set; }

    event TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> ContainerContentChanging;

    void SetDesiredContainerUpdateDuration(TimeSpan duration);

    object Footer { get; set; }

    DataTemplate FooterTemplate { get; set; }

    TransitionCollection FooterTransitions { get; set; }
  }
}
