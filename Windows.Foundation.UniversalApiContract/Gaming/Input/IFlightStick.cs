// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IFlightStick
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (FlightStick))]
  [Guid(3030564892, 47163, 17497, 161, 169, 151, 176, 60, 51, 218, 124)]
  internal interface IFlightStick : IGameController
  {
    GameControllerSwitchKind HatSwitchKind { get; }

    GameControllerButtonLabel GetButtonLabel(FlightStickButtons button);

    FlightStickReading GetCurrentReading();
  }
}
