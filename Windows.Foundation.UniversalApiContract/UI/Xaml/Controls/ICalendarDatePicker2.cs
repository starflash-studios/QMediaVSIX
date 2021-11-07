// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePicker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CalendarDatePicker))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2987835737, 9233, 19040, 167, 170, 39, 65, 107, 73, 72, 30)]
  internal interface ICalendarDatePicker2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
