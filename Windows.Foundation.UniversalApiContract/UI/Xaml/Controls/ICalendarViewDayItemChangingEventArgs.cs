// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItemChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1930716774, 8113, 17657, 183, 173, 77, 232, 89, 236, 197, 101)]
  [ExclusiveTo(typeof (CalendarViewDayItemChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarViewDayItemChangingEventArgs
  {
    bool InRecycleQueue { get; }

    CalendarViewDayItem Item { get; }

    uint Phase { get; }

    [Overload("RegisterUpdateCallback")]
    void RegisterUpdateCallback(
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);

    [Overload("RegisterUpdateCallbackWithPhase")]
    void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);
  }
}
