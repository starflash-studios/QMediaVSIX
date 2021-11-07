// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePicker))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(405699689, 8470, 19559, 181, 19, 113, 51, 100, 131, 29, 121)]
  internal interface IDatePickerStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty DateProperty { get; }

    DependencyProperty DayVisibleProperty { get; }

    DependencyProperty MonthVisibleProperty { get; }

    DependencyProperty YearVisibleProperty { get; }

    DependencyProperty DayFormatProperty { get; }

    DependencyProperty MonthFormatProperty { get; }

    DependencyProperty YearFormatProperty { get; }

    DependencyProperty MinYearProperty { get; }

    DependencyProperty MaxYearProperty { get; }

    DependencyProperty OrientationProperty { get; }
  }
}
