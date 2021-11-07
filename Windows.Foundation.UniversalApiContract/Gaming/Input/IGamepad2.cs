// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepad2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Gamepad))]
  [Guid(1008110013, 22805, 16965, 176, 192, 200, 159, 174, 3, 8, 255)]
  internal interface IGamepad2 : IGamepad, IGameController
  {
    GameControllerButtonLabel GetButtonLabel(GamepadButtons button);
  }
}
