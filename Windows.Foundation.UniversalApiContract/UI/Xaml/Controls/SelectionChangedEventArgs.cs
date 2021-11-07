// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SelectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the SelectionChanged event.</summary>
  [WebHostHidden]
  [Composable(typeof (ISelectionChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class SelectionChangedEventArgs : RoutedEventArgs, ISelectionChangedEventArgs
  {
    [MethodImpl]
    public extern SelectionChangedEventArgs(
      IVector<object> removedItems,
      IVector<object> addedItems);

    /// <summary>Gets a list that contains the items that were selected.</summary>
    /// <returns>The loosely typed collection of items that were selected in this event.</returns>
    public extern IVector<object> AddedItems { [MethodImpl] get; }

    /// <summary>Gets a list that contains the items that were unselected.</summary>
    /// <returns>The loosely typed list of items that were unselected in this event.</returns>
    public extern IVector<object> RemovedItems { [MethodImpl] get; }
  }
}
