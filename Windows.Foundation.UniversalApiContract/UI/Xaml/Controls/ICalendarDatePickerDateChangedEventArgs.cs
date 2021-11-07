// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePickerDateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1624837554, 20496, 18106, 132, 45, 164, 21, 44, 101, 4, 231)]
  [ExclusiveTo(typeof (CalendarDatePickerDateChangedEventArgs))]
  internal interface ICalendarDatePickerDateChangedEventArgs
  {
    IReference<DateTime> NewDate { get; }

    IReference<DateTime> OldDate { get; }
  }
}
