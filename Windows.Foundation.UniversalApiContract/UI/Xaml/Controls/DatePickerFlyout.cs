// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that allows a user to pick a date.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDatePickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDatePickerFlyoutStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DatePickerFlyout : PickerFlyoutBase, IDatePickerFlyout, IDatePickerFlyout2
  {
    /// <summary>Initializes a new instance of the DatePickerFlyout class.</summary>
    [MethodImpl]
    public extern DatePickerFlyout();

    /// <summary>Gets or sets the calendar system to use.</summary>
    /// <returns>The name of the calendar system to use. For a list of supported calendar systems, see CalendarIdentifiers.</returns>
    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date currently set in the date picker.</summary>
    /// <returns>The date currently set in the picker.</returns>
    public extern DateTime Date { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the day selector is shown.</summary>
    /// <returns>True if the day selector is shown; otherwise, false. The default is true.</returns>
    public extern bool DayVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the month selector is shown.</summary>
    /// <returns>True if the month selector is shown; otherwise, false. The default is true.</returns>
    public extern bool MonthVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the year selector is shown.</summary>
    /// <returns>True if the year selector is shown; otherwise, false. The default is true.</returns>
    public extern bool YearVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum Gregorian year available for picking.</summary>
    /// <returns>The minimum Gregorian year available for picking.</returns>
    public extern DateTime MinYear { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum Gregorian year available for picking.</summary>
    /// <returns>The maximum Gregorian year available for picking.S</returns>
    public extern DateTime MaxYear { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a date has been picked by the user.</summary>
    public extern event TypedEventHandler<DatePickerFlyout, DatePickedEventArgs> DatePicked;

    /// <summary>Begins an asynchronous operation to show the date picker placed in relation to the specified element.</summary>
    /// <param name="target">The element to use as the flyout's placement target.</param>
    /// <returns>An asynchronous operation</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IReference<DateTime>> ShowAtAsync(
      FrameworkElement target);

    /// <summary>Gets or sets the display format for the day value.</summary>
    /// <returns>The display format for the day value.</returns>
    public extern string DayFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the month value.</summary>
    /// <returns>The display format for the month value.</returns>
    public extern string MonthFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the year value.</summary>
    /// <returns>The display format for the year value.</returns>
    public extern string YearFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the DayFormat dependency property.</summary>
    /// <returns>The identifier for the DayFormat dependency property.</returns>
    public static extern DependencyProperty DayFormatProperty { [MethodImpl] get; }

    /// <summary>Identifies the MonthFormat dependency property.</summary>
    /// <returns>The identifier for the MonthFormat dependency property.</returns>
    public static extern DependencyProperty MonthFormatProperty { [MethodImpl] get; }

    /// <summary>Identifies the YearFormat dependency property.</summary>
    /// <returns>The identifier for the YearFormat dependency property.</returns>
    public static extern DependencyProperty YearFormatProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the CalendarIdentifier dependency property.</summary>
    /// <returns>The identifier for the CalendarIdentifier dependency property.</returns>
    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Date dependency property.</summary>
    /// <returns>The identifier for the Date dependency property.</returns>
    public static extern DependencyProperty DateProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DayVisible dependency property.</summary>
    /// <returns>The identifier for the DayVisible dependency property.</returns>
    public static extern DependencyProperty DayVisibleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MonthVisible dependency property.</summary>
    /// <returns>The identifier for the MonthVisible dependency property.</returns>
    public static extern DependencyProperty MonthVisibleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the YearVisible dependency property.</summary>
    /// <returns>The identifier for the YearVisible dependency property.</returns>
    public static extern DependencyProperty YearVisibleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MinYear dependency property.</summary>
    /// <returns>The identifier for the MinYear dependency property.</returns>
    public static extern DependencyProperty MinYearProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MaxYear dependency property.</summary>
    /// <returns>The identifier for the MaxYear dependency property.</returns>
    public static extern DependencyProperty MaxYearProperty { [MethodImpl] get; }
  }
}
