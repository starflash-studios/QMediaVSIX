// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarDatePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(967037585, 44971, 19348, 131, 149, 186, 123, 135, 78, 60, 140)]
  internal interface ICalendarDatePickerStatics
  {
    DependencyProperty DateProperty { get; }

    DependencyProperty IsCalendarOpenProperty { get; }

    DependencyProperty DateFormatProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty CalendarViewStyleProperty { get; }

    DependencyProperty MinDateProperty { get; }

    DependencyProperty MaxDateProperty { get; }

    DependencyProperty IsTodayHighlightedProperty { get; }

    DependencyProperty DisplayModeProperty { get; }

    DependencyProperty FirstDayOfWeekProperty { get; }

    DependencyProperty DayOfWeekFormatProperty { get; }

    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty IsOutOfScopeEnabledProperty { get; }

    DependencyProperty IsGroupLabelVisibleProperty { get; }
  }
}
