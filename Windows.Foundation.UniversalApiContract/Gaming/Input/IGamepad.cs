// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepad
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (Gamepad))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3162223676, 2665, 14595, 158, 157, 165, 15, 134, 164, 93, 229)]
  internal interface IGamepad : IGameController
  {
    GamepadVibration Vibration { get; set; }

    GamepadReading GetCurrentReading();
  }
}
