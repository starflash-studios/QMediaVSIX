// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePicker))]
  [Guid(114964806, 2232, 16643, 139, 138, 9, 62, 253, 106, 118, 87)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePicker
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string CalendarIdentifier { get; set; }

    DateTime Date { get; set; }

    bool DayVisible { get; set; }

    bool MonthVisible { get; set; }

    bool YearVisible { get; set; }

    string DayFormat { get; set; }

    string MonthFormat { get; set; }

    string YearFormat { get; set; }

    DateTime MinYear { get; set; }

    DateTime MaxYear { get; set; }

    Orientation Orientation { get; set; }

    event EventHandler<DatePickerValueChangedEventArgs> DateChanged;
  }
}
