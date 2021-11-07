// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Provides the event data for a CollectionChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (INotifyCollectionChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class NotifyCollectionChangedEventArgs : INotifyCollectionChangedEventArgs
  {
    [MethodImpl]
    public extern NotifyCollectionChangedEventArgs(
      NotifyCollectionChangedAction action,
      IBindableVector newItems,
      IBindableVector oldItems,
      int newIndex,
      int oldIndex);

    /// <summary>Gets the description of the action that caused the event.</summary>
    /// <returns>The description of the action that caused the event, as a value of the enumeration.</returns>
    public extern NotifyCollectionChangedAction Action { [MethodImpl] get; }

    /// <summary>Gets the items affected by an action.</summary>
    /// <returns>The bindable vector of items affected by an action.</returns>
    public extern IBindableVector NewItems { [MethodImpl] get; }

    /// <summary>Gets the item affected by a **Replace** or **Remove** action.</summary>
    /// <returns>The bindable vector of items affected by a **Replace** or **Remove** action.</returns>
    public extern IBindableVector OldItems { [MethodImpl] get; }

    /// <summary>Gets the index at which the change occurred.</summary>
    /// <returns>The index at which the change occurred.</returns>
    public extern int NewStartingIndex { [MethodImpl] get; }

    /// <summary>Gets the starting index at which a **Move**, **Remove**, or **Replace** action occurred.</summary>
    /// <returns>The zero-based index at which a **Move**, **Remove**, or **Replace** action occurred.</returns>
    public extern int OldStartingIndex { [MethodImpl] get; }
  }
}
