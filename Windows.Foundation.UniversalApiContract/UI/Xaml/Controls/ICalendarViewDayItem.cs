// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CalendarViewDayItem))]
  [Guid(266022341, 12993, 19343, 190, 252, 1, 123, 85, 91, 50, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICalendarViewDayItem
  {
    bool IsBlackout { get; set; }

    DateTime Date { get; }

    void SetDensityColors(IIterable<Color> colors);
  }
}
