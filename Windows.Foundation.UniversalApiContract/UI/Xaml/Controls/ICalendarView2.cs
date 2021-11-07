// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CalendarView))]
  [WebHostHidden]
  [Guid(4116362826, 21764, 23966, 157, 32, 47, 253, 184, 143, 197, 107)]
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  internal interface ICalendarView2
  {
    Brush SelectedDisabledBorderBrush { get; set; }

    Brush TodaySelectedInnerBorderBrush { get; set; }

    Brush BlackoutStrikethroughBrush { get; set; }

    Brush BlackoutBackground { get; set; }

    Brush CalendarItemHoverBackground { get; set; }

    Brush CalendarItemPressedBackground { get; set; }

    Brush CalendarItemDisabledBackground { get; set; }

    Brush TodayBackground { get; set; }

    Brush TodayBlackoutBackground { get; set; }

    Brush TodayHoverBackground { get; set; }

    Brush TodayPressedBackground { get; set; }

    Brush TodayDisabledBackground { get; set; }

    Brush TodayBlackoutForeground { get; set; }

    Brush SelectedHoverForeground { get; set; }

    Brush SelectedPressedForeground { get; set; }

    Brush SelectedDisabledForeground { get; set; }

    Brush OutOfScopeHoverForeground { get; set; }

    Brush OutOfScopePressedForeground { get; set; }

    Brush DisabledForeground { get; set; }

    Thickness DayItemMargin { get; set; }

    Thickness MonthYearItemMargin { get; set; }

    Thickness FirstOfMonthLabelMargin { get; set; }

    Thickness FirstOfYearDecadeLabelMargin { get; set; }

    CornerRadius CalendarItemCornerRadius { get; set; }
  }
}
