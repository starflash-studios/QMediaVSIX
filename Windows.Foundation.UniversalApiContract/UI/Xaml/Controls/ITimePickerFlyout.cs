// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TimePickerFlyout))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3144916341, 59446, 17310, 134, 213, 80, 109, 45, 24, 228, 4)]
  internal interface ITimePickerFlyout
  {
    string ClockIdentifier { get; set; }

    TimeSpan Time { get; set; }

    int MinuteIncrement { get; set; }

    event TypedEventHandler<TimePickerFlyout, TimePickedEventArgs> TimePicked;

    [RemoteAsync]
    IAsyncOperation<IReference<TimeSpan>> ShowAtAsync(
      FrameworkElement target);
  }
}
