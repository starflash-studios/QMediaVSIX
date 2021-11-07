// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePickerFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4227021594, 41892, 19960, 146, 40, 35, 165, 172, 39, 223, 78)]
  [WebHostHidden]
  internal interface IDatePickerFlyout
  {
    string CalendarIdentifier { get; set; }

    DateTime Date { get; set; }

    bool DayVisible { get; set; }

    bool MonthVisible { get; set; }

    bool YearVisible { get; set; }

    DateTime MinYear { get; set; }

    DateTime MaxYear { get; set; }

    event TypedEventHandler<DatePickerFlyout, DatePickedEventArgs> DatePicked;

    [RemoteAsync]
    IAsyncOperation<IReference<DateTime>> ShowAtAsync(
      FrameworkElement target);
  }
}
