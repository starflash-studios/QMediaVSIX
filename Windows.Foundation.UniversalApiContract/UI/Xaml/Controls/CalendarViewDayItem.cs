// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewDayItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a day on a CalendarView.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICalendarViewDayItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ICalendarViewDayItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class CalendarViewDayItem : Control, ICalendarViewDayItem
  {
    /// <summary>Initializes a new instance of the CalendarViewDayItem class.</summary>
    [MethodImpl]
    public extern CalendarViewDayItem();

    /// <summary>Gets or sets a value that indicates whether the date is unavailable.</summary>
    /// <returns>**true** if the date unavailable; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsBlackout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the date represented by this item.</summary>
    /// <returns>The date represented by this item.</returns>
    public extern DateTime Date { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetDensityColors(IIterable<Color> colors);

    /// <summary>Identifies the IsBlackout  dependency property.</summary>
    /// <returns>The identifier for the IsBlackout  dependency property.</returns>
    public static extern DependencyProperty IsBlackoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the Date  dependency property.</summary>
    /// <returns>The identifier for the Date  dependency property.</returns>
    public static extern DependencyProperty DateProperty { [MethodImpl] get; }
  }
}
