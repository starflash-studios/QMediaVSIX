// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(380750073, 31393, 24120, 130, 24, 123, 186, 62, 164, 23, 192)]
  [ExclusiveTo(typeof (TreeView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITreeViewStatics2
  {
    DependencyProperty CanDragItemsProperty { get; }

    DependencyProperty CanReorderItemsProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }

    DependencyProperty ItemTemplateSelectorProperty { get; }

    DependencyProperty ItemContainerStyleProperty { get; }

    DependencyProperty ItemContainerStyleSelectorProperty { get; }

    DependencyProperty ItemContainerTransitionsProperty { get; }

    DependencyProperty ItemsSourceProperty { get; }
  }
}
