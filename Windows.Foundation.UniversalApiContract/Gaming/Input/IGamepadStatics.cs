// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepadStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(2344412457, 54428, 14825, 149, 96, 228, 125, 222, 150, 183, 200)]
  [ExclusiveTo(typeof (Gamepad))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGamepadStatics
  {
    event EventHandler<Gamepad> GamepadAdded;

    event EventHandler<Gamepad> GamepadRemoved;

    IVectorView<Gamepad> Gamepads { get; }
  }
}
