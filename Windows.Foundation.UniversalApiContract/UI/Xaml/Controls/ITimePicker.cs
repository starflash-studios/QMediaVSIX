// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3817904626, 15103, 18322, 144, 158, 45, 153, 65, 236, 3, 87)]
  [ExclusiveTo(typeof (TimePicker))]
  internal interface ITimePicker
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string ClockIdentifier { get; set; }

    int MinuteIncrement { get; set; }

    TimeSpan Time { get; set; }

    event EventHandler<TimePickerValueChangedEventArgs> TimeChanged;
  }
}
