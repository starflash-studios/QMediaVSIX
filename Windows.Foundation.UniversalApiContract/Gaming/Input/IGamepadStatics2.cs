// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepadStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(1114074565, 2134, 18372, 146, 19, 179, 149, 80, 76, 58, 60)]
  [ExclusiveTo(typeof (Gamepad))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGamepadStatics2 : IGamepadStatics
  {
    Gamepad FromGameController(IGameController gameController);
  }
}
