// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyoutStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3445031799, 22597, 19474, 140, 16, 89, 45, 159, 204, 124, 217)]
  [ExclusiveTo(typeof (DatePickerFlyout))]
  internal interface IDatePickerFlyoutStatics
  {
    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty DateProperty { get; }

    DependencyProperty DayVisibleProperty { get; }

    DependencyProperty MonthVisibleProperty { get; }

    DependencyProperty YearVisibleProperty { get; }

    DependencyProperty MinYearProperty { get; }

    DependencyProperty MaxYearProperty { get; }
  }
}
