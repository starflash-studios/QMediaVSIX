// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IArcadeStick
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (ArcadeStick))]
  [Guid(2974438301, 48891, 19585, 128, 81, 21, 236, 243, 177, 48, 54)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IArcadeStick : IGameController
  {
    GameControllerButtonLabel GetButtonLabel(ArcadeStickButtons button);

    ArcadeStickReading GetCurrentReading();
  }
}
