// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4104723928, 55673, 17281, 134, 82, 189, 160, 52, 42, 118, 94)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsControl))]
  internal interface IItemsControl
  {
    object ItemsSource { get; set; }

    ItemCollection Items { get; }

    DataTemplate ItemTemplate { get; set; }

    DataTemplateSelector ItemTemplateSelector { get; set; }

    ItemsPanelTemplate ItemsPanel { get; set; }

    string DisplayMemberPath { get; set; }

    Style ItemContainerStyle { get; set; }

    StyleSelector ItemContainerStyleSelector { get; set; }

    ItemContainerGenerator ItemContainerGenerator { get; }

    TransitionCollection ItemContainerTransitions { get; set; }

    IObservableVector<global::Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { get; }

    GroupStyleSelector GroupStyleSelector { get; set; }

    bool IsGrouping { get; }
  }
}
