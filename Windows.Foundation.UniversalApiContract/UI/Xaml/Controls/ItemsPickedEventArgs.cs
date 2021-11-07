// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsPickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the ItemsPicked event.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ItemsPickedEventArgs : DependencyObject, IItemsPickedEventArgs
  {
    /// <summary>Initializes a new instance of the ItemsPickedEventArgs class.</summary>
    [MethodImpl]
    public extern ItemsPickedEventArgs();

    /// <summary>Gets the collection of items that were selected by the user.</summary>
    /// <returns>The collection of items that were selected by the user.</returns>
    public extern IVector<object> AddedItems { [MethodImpl] get; }

    /// <summary>Gets the collection of items that were unselected.</summary>
    /// <returns>The collection of items that were unselected.</returns>
    public extern IVector<object> RemovedItems { [MethodImpl] get; }
  }
}
