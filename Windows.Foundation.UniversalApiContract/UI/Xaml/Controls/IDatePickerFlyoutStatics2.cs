// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyoutStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePickerFlyout))]
  [WebHostHidden]
  [Guid(2949899625, 33254, 19284, 132, 169, 104, 7, 155, 115, 227, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePickerFlyoutStatics2
  {
    DependencyProperty DayFormatProperty { get; }

    DependencyProperty MonthFormatProperty { get; }

    DependencyProperty YearFormatProperty { get; }
  }
}
