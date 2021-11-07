// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPenButtonListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (PenButtonListener))]
  [Guid(2185610102, 7907, 21495, 177, 247, 131, 52, 161, 111, 40, 21)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IPenButtonListener
  {
    bool IsSupported();

    event TypedEventHandler<PenButtonListener, object> IsSupportedChanged;

    event TypedEventHandler<PenButtonListener, PenTailButtonClickedEventArgs> TailButtonClicked;

    event TypedEventHandler<PenButtonListener, PenTailButtonDoubleClickedEventArgs> TailButtonDoubleClicked;

    event TypedEventHandler<PenButtonListener, PenTailButtonLongPressedEventArgs> TailButtonLongPressed;
  }
}
