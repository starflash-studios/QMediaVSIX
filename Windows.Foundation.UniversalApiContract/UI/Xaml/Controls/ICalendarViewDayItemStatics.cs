// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarViewDayItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3282164671, 48520, 18571, 185, 22, 208, 13, 105, 177, 115, 90)]
  internal interface ICalendarViewDayItemStatics
  {
    DependencyProperty IsBlackoutProperty { get; }

    DependencyProperty DateProperty { get; }
  }
}
