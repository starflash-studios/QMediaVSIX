// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePicker3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DatePicker))]
  [Guid(2107714107, 42852, 23265, 171, 174, 106, 255, 193, 66, 142, 30)]
  internal interface IDatePicker3
  {
    IReference<DateTime> SelectedDate { get; set; }

    event TypedEventHandler<DatePicker, DatePickerSelectedValueChangedEventArgs> SelectedDateChanged;
  }
}
