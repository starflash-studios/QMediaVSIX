// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ICalendarDatePickerAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(2876267986, 53907, 17855, 159, 25, 38, 247, 96, 58, 94, 155)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CalendarDatePickerAutomationPeer))]
  [WebHostHidden]
  internal interface ICalendarDatePickerAutomationPeerFactory
  {
    CalendarDatePickerAutomationPeer CreateInstanceWithOwner(
      CalendarDatePicker owner,
      object baseInterface,
      out object innerInterface);
  }
}
