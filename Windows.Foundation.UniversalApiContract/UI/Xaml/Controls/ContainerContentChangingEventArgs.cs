// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the ContainerContentChanging event.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class ContainerContentChangingEventArgs : IContainerContentChangingEventArgs
  {
    /// <summary>Initializes a new instance of the ContainerContentChangingEventArgs class.</summary>
    [MethodImpl]
    public extern ContainerContentChangingEventArgs();

    /// <summary>Gets the UI container used to display the current data item.</summary>
    /// <returns>The UI container used to display the current data item.</returns>
    public extern SelectorItem ItemContainer { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether this container is in the recycle queue of the ListViewBase and is not being used to visualize a data item.</summary>
    /// <returns>**true** if the container is in the recycle queue of the ListViewBase; otherwise, **false**.</returns>
    public extern bool InRecycleQueue { [MethodImpl] get; }

    /// <summary>Gets the index in the ItemsSource of the data item associated with this container.</summary>
    /// <returns>The index in the ItemsSource of the data item associated with this container. The default is -1.</returns>
    public extern int ItemIndex { [MethodImpl] get; }

    /// <summary>Gets the data item associated with this container.</summary>
    /// <returns>The data item associated with this container, or **null** if no data is associated with this container.</returns>
    public extern object Item { [MethodImpl] get; }

    /// <summary>Gets the number of times this container and data item pair has been called.</summary>
    /// <returns>The number of times this container and data item pair has been called.</returns>
    public extern uint Phase { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Registers the event handler to be called again during the next phase.</summary>
    /// <param name="callback">The event handler function.</param>
    [Overload("RegisterUpdateCallback")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);

    /// <summary>Registers the event handler to be called again during the specified phase.</summary>
    /// <param name="callbackPhase">The phase during which the callback should occur.</param>
    /// <param name="callback">The event handler function.</param>
    [Overload("RegisterUpdateCallbackWithPhase")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);
  }
}
