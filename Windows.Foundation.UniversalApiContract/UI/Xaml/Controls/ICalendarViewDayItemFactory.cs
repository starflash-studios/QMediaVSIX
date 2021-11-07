// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItemFactory
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
  [Guid(1645292508, 7471, 20036, 155, 175, 22, 101, 116, 149, 33, 242)]
  internal interface ICalendarViewDayItemFactory
  {
    CalendarViewDayItem CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
