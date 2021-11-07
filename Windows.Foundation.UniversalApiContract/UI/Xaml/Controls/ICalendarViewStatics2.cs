// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CalendarView))]
  [Guid(4070461476, 47355, 20680, 138, 56, 212, 67, 171, 179, 112, 9)]
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  [WebHostHidden]
  internal interface ICalendarViewStatics2
  {
    DependencyProperty SelectedDisabledBorderBrushProperty { get; }

    DependencyProperty TodaySelectedInnerBorderBrushProperty { get; }

    DependencyProperty BlackoutStrikethroughBrushProperty { get; }

    DependencyProperty BlackoutBackgroundProperty { get; }

    DependencyProperty CalendarItemHoverBackgroundProperty { get; }

    DependencyProperty CalendarItemPressedBackgroundProperty { get; }

    DependencyProperty CalendarItemDisabledBackgroundProperty { get; }

    DependencyProperty TodayBackgroundProperty { get; }

    DependencyProperty TodayBlackoutBackgroundProperty { get; }

    DependencyProperty TodayHoverBackgroundProperty { get; }

    DependencyProperty TodayPressedBackgroundProperty { get; }

    DependencyProperty TodayDisabledBackgroundProperty { get; }

    DependencyProperty TodayBlackoutForegroundProperty { get; }

    DependencyProperty SelectedHoverForegroundProperty { get; }

    DependencyProperty SelectedPressedForegroundProperty { get; }

    DependencyProperty SelectedDisabledForegroundProperty { get; }

    DependencyProperty OutOfScopeHoverForegroundProperty { get; }

    DependencyProperty OutOfScopePressedForegroundProperty { get; }

    DependencyProperty DisabledForegroundProperty { get; }

    DependencyProperty DayItemMarginProperty { get; }

    DependencyProperty MonthYearItemMarginProperty { get; }

    DependencyProperty FirstOfMonthLabelMarginProperty { get; }

    DependencyProperty FirstOfYearDecadeLabelMarginProperty { get; }

    DependencyProperty CalendarItemCornerRadiusProperty { get; }
  }
}
