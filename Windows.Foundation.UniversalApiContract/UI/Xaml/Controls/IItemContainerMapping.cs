// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemContainerMapping
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides methods that let an ItemsControl map data items to UI containers.</summary>
  [WebHostHidden]
  [Guid(1405743674, 62045, 17514, 153, 184, 199, 174, 184, 57, 5, 15)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IItemContainerMapping
  {
    /// <summary>Returns the item that corresponds to the specified, generated container.</summary>
    /// <param name="container">The DependencyObject that corresponds to the item to be returned.</param>
    /// <returns>The contained item, or the container if it does not contain an item.</returns>
    object ItemFromContainer(DependencyObject container);

    /// <summary>Returns the container corresponding to the specified item.</summary>
    /// <param name="item">The item to retrieve the container for.</param>
    /// <returns>A container that corresponds to the specified item, if the item has a container and exists in the collection; otherwise, **null**.</returns>
    DependencyObject ContainerFromItem(object item);

    /// <summary>Returns the index to the item that has the specified, generated container.</summary>
    /// <param name="container">The generated container to retrieve the item index for.</param>
    /// <returns>The index to the item that corresponds to the specified generated container.</returns>
    int IndexFromContainer(DependencyObject container);

    /// <summary>Returns the container for the item at the specified index within the ItemCollection.</summary>
    /// <param name="index">The index of the item to retrieve.</param>
    /// <returns>The container for the item at the specified index within the item collection, if the item has a container; otherwise, **null**.</returns>
    DependencyObject ContainerFromIndex(int index);
  }
}
