// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyout2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3484519867, 39217, 16665, 139, 218, 84, 168, 111, 223, 172, 132)]
  [ExclusiveTo(typeof (DatePickerFlyout))]
  [WebHostHidden]
  internal interface IDatePickerFlyout2
  {
    string DayFormat { get; set; }

    string MonthFormat { get; set; }

    string YearFormat { get; set; }
  }
}
