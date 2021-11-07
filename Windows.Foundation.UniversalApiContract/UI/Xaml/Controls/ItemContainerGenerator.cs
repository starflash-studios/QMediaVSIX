// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemContainerGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides mappings between the items of an ItemsControl and their container elements.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ItemContainerGenerator : IItemContainerGenerator
  {
    /// <summary>Occurs when the contents of the items collection changes.</summary>
    public extern event ItemsChangedEventHandler ItemsChanged;

    /// <summary>Returns the item that corresponds to the specified, generated container.</summary>
    /// <deprecated type="deprecate">ItemFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ItemFromContainer.</deprecated>
    /// <param name="container">The DependencyObject that corresponds to the item to be returned.</param>
    /// <returns>The contained item, or the container if it does not contain an item.</returns>
    [Deprecated("ItemFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ItemFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern object ItemFromContainer(DependencyObject container);

    /// <summary>Returns the container corresponding to the specified item.</summary>
    /// <deprecated type="deprecate">ContainerFromItem may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromItem.</deprecated>
    /// <param name="item">The item to retrieve the container for.</param>
    /// <returns>A container that corresponds to the specified item, if the item has a container and exists in the collection; otherwise, **null**.</returns>
    [Deprecated("ContainerFromItem may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromItem.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern DependencyObject ContainerFromItem(object item);

    /// <summary>Returns the index to the item that has the specified, generated container.</summary>
    /// <deprecated type="deprecate">IndexFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.IndexFromContainer.</deprecated>
    /// <param name="container">The generated container to retrieve the item index for.</param>
    /// <returns>The index to the item that corresponds to the specified generated container.</returns>
    [Deprecated("IndexFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.IndexFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern int IndexFromContainer(DependencyObject container);

    /// <summary>Returns the container for the item at the specified index within the ItemCollection.</summary>
    /// <deprecated type="deprecate">ContainerFromIndex may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromIndex.</deprecated>
    /// <param name="index">The index of the item to retrieve.</param>
    /// <returns>The container for the item at the specified index within the item collection, if the item has a container; otherwise, null.</returns>
    [Deprecated("ContainerFromIndex may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromIndex.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern DependencyObject ContainerFromIndex(int index);

    /// <summary>Returns the ItemContainerGenerator that is appropriate for use by the specified panel.</summary>
    /// <param name="panel">The panel for which to return an appropriate ItemContainerGenerator.</param>
    /// <returns>An ItemContainerGenerator appropriate for use by the specified panel.</returns>
    [MethodImpl]
    public extern ItemContainerGenerator GetItemContainerGeneratorForPanel(
      Panel panel);

    /// <summary>Prepares the generator to generate items, starting at the specified GeneratorPosition and moving in the specified GeneratorDirection. This method also controls whether or not to start at a generated (realized) item.</summary>
    /// <param name="position">A GeneratorPosition that specifies the position of the item to start generating items at.</param>
    /// <param name="direction">Specifies the position of the item to start generating items at.</param>
    /// <param name="allowStartAtRealizedItem">Specifies whether to start at a generated (realized) item.</param>
    [MethodImpl]
    public extern void StartAt(
      GeneratorPosition position,
      GeneratorDirection direction,
      bool allowStartAtRealizedItem);

    /// <summary>Disposes the ItemContainerGenerator. </summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Returns the container element used to display the next item, and indicates whether the container element has been newly generated (realized).</summary>
    /// <param name="isNewlyRealized">**true** if the returned DependencyObject is newly generated (realized); otherwise, **false**.</param>
    /// <returns>A DependencyObject that is the container element that is used to display the next item.</returns>
    [MethodImpl]
    public extern DependencyObject GenerateNext(out bool isNewlyRealized);

    /// <summary>Prepares the specified element as the container for the corresponding item.</summary>
    /// <param name="container">The container to prepare. Typically, *container* is the result of the previous call to GenerateNext.</param>
    [MethodImpl]
    public extern void PrepareItemContainer(DependencyObject container);

    /// <summary>Removes all generated (realized) items.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    /// <summary>Removes one or more generated (realized) items.</summary>
    /// <param name="position">The index of the element to remove. *position* must refer to a previously generated (realized) item, which means its offset must be zero.</param>
    /// <param name="count">The number of elements to remove, starting at *position*.</param>
    [MethodImpl]
    public extern void Remove(GeneratorPosition position, int count);

    /// <summary>Gets the generated position of the item at the specified index.</summary>
    /// <param name="itemIndex">The index of the item to retrieve the position of.</param>
    /// <returns>The position of the item as generated by the ItemContainerGenerator.</returns>
    [MethodImpl]
    public extern GeneratorPosition GeneratorPositionFromIndex(int itemIndex);

    /// <summary>Returns the index that maps to the specified GeneratorPosition.</summary>
    /// <param name="position">The GeneratorPosition for the desired index.</param>
    /// <returns>The index that maps to the specified GeneratorPosition.</returns>
    [MethodImpl]
    public extern int IndexFromGeneratorPosition(GeneratorPosition position);

    /// <summary>Disassociates item containers from their data items and saves the containers so they can be reused later for other data items.</summary>
    /// <param name="position">The zero-based index of the first element to reuse. *position* must refer to a previously generated (realized) item.</param>
    /// <param name="count">The number of elements to reuse, starting at *position*.</param>
    [MethodImpl]
    public extern void Recycle(GeneratorPosition position, int count);
  }
}
