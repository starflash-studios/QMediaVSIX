// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1328784102, 12073, 21971, 161, 171, 31, 74, 134, 59, 249, 96)]
  [ExclusiveTo(typeof (TreeView))]
  internal interface ITreeView2
  {
    TreeViewNode NodeFromContainer(DependencyObject container);

    DependencyObject ContainerFromNode(TreeViewNode node);

    object ItemFromContainer(DependencyObject container);

    DependencyObject ContainerFromItem(object item);

    bool CanDragItems { get; set; }

    bool CanReorderItems { get; set; }

    DataTemplate ItemTemplate { get; set; }

    DataTemplateSelector ItemTemplateSelector { get; set; }

    Style ItemContainerStyle { get; set; }

    StyleSelector ItemContainerStyleSelector { get; set; }

    TransitionCollection ItemContainerTransitions { get; set; }

    object ItemsSource { get; set; }

    event TypedEventHandler<TreeView, TreeViewDragItemsStartingEventArgs> DragItemsStarting;

    event TypedEventHandler<TreeView, TreeViewDragItemsCompletedEventArgs> DragItemsCompleted;
  }
}
