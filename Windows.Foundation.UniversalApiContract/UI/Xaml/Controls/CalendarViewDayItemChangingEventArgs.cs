// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the CalendarViewDayItemChanging event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class CalendarViewDayItemChangingEventArgs : ICalendarViewDayItemChangingEventArgs
  {
    /// <summary>Gets a value that indicates whether this container is in the recycle queue of the CalendarView and is not being used to visualize a calendar item.</summary>
    /// <returns>**true** if the container is in the recycle queue of the CalendarView; otherwise, **false**.</returns>
    public extern bool InRecycleQueue { [MethodImpl] get; }

    /// <summary>Gets the calendar day item associated with this container.</summary>
    /// <returns>The CalendarViewDayItem associated with this container, or **null** if no item is associated with this container.</returns>
    public extern CalendarViewDayItem Item { [MethodImpl] get; }

    /// <summary>Gets the number of times this container and day item pair has been called.</summary>
    /// <returns>The number of times this container and day item pair has been called.</returns>
    public extern uint Phase { [MethodImpl] get; }

    /// <summary>Registers the event handler to be called again during the next phase.</summary>
    /// <param name="callback">The event handler function.</param>
    [Overload("RegisterUpdateCallback")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);

    /// <summary>Registers the event handler to be called again during the specified phase.</summary>
    /// <param name="callbackPhase">The phase during which the callback should occur.</param>
    /// <param name="callback">The event handler function.</param>
    [Overload("RegisterUpdateCallbackWithPhase")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);
  }
}
