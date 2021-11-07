// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemContainerGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemContainerGenerator))]
  [WebHostHidden]
  [Guid(1081499392, 33776, 19839, 177, 184, 241, 157, 228, 241, 213, 218)]
  internal interface IItemContainerGenerator
  {
    event ItemsChangedEventHandler ItemsChanged;

    [Deprecated("ItemFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ItemFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    object ItemFromContainer(DependencyObject container);

    [Deprecated("ContainerFromItem may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromItem.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DependencyObject ContainerFromItem(object item);

    [Deprecated("IndexFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.IndexFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    int IndexFromContainer(DependencyObject container);

    [Deprecated("ContainerFromIndex may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromIndex.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DependencyObject ContainerFromIndex(int index);

    ItemContainerGenerator GetItemContainerGeneratorForPanel(Panel panel);

    void StartAt(
      GeneratorPosition position,
      GeneratorDirection direction,
      bool allowStartAtRealizedItem);

    void Stop();

    DependencyObject GenerateNext(out bool isNewlyRealized);

    void PrepareItemContainer(DependencyObject container);

    void RemoveAll();

    void Remove(GeneratorPosition position, int count);

    GeneratorPosition GeneratorPositionFromIndex(int itemIndex);

    int IndexFromGeneratorPosition(GeneratorPosition position);

    void Recycle(GeneratorPosition position, int count);
  }
}
