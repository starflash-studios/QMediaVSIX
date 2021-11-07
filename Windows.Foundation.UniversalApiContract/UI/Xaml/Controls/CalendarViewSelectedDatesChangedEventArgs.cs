// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the SelectedDatesChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CalendarViewSelectedDatesChangedEventArgs : 
    ICalendarViewSelectedDatesChangedEventArgs
  {
    /// <summary>Gets a collection that contains the items that were selected.</summary>
    /// <returns>The items that were selected since the last time the SelectedDatesChanged event occurred.</returns>
    public extern IVectorView<DateTime> AddedDates { [MethodImpl] get; }

    /// <summary>Gets a collection that contains the items that were unselected.</summary>
    /// <returns>The items that were unselected since the last time the SelectedDatesChanged event occurred.</returns>
    public extern IVectorView<DateTime> RemovedDates { [MethodImpl] get; }
  }
}
