// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewPersistenceHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a helper class to save and retrieve the relative scroll position of the ListView.</summary>
  [Static(typeof (IListViewPersistenceHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ListViewPersistenceHelper : IListViewPersistenceHelper
  {
    /// <summary>Retrieves the relative scroll position of the ListView.</summary>
    /// <param name="listViewBase">The ListView object.</param>
    /// <param name="itemToKeyHandler">The method that will handle the retrieval of the item key.</param>
    /// <returns>The relative scroll position of the ListView.</returns>
    [MethodImpl]
    public static extern string GetRelativeScrollPosition(
      ListViewBase listViewBase,
      ListViewItemToKeyHandler itemToKeyHandler);

    /// <summary>Begins an asynchronous action to set the relative scroll position of the ListView.</summary>
    /// <param name="listViewBase">The ListView.</param>
    /// <param name="relativeScrollPosition">The relative scroll position of the ListView.</param>
    /// <param name="keyToItemHandler">The method that will handle the retrieval of the ListView item given the key.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetRelativeScrollPositionAsync(
      ListViewBase listViewBase,
      string relativeScrollPosition,
      ListViewKeyToItemHandler keyToItemHandler);
  }
}
