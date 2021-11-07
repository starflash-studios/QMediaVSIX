// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverInputDevices
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [Guid(3660954370, 10410, 24296, 150, 245, 164, 41, 1, 198, 111, 0)]
  [ExclusiveTo(typeof (MiracastReceiverInputDevices))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverInputDevices
  {
    MiracastReceiverKeyboardDevice Keyboard { get; }

    MiracastReceiverGameControllerDevice GameController { get; }
  }
}
