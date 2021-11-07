// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePicker3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4201533329, 44082, 22948, 148, 218, 139, 61, 100, 40, 158, 214)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (TimePicker))]
  internal interface ITimePicker3
  {
    IReference<TimeSpan> SelectedTime { get; set; }

    event TypedEventHandler<TimePicker, TimePickerSelectedValueChangedEventArgs> SelectedTimeChanged;
  }
}
