// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IFlightStickStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1427411530, 65228, 17246, 131, 220, 92, 236, 138, 24, 165, 32)]
  [ExclusiveTo(typeof (FlightStick))]
  internal interface IFlightStickStatics
  {
    event EventHandler<FlightStick> FlightStickAdded;

    event EventHandler<FlightStick> FlightStickRemoved;

    IVectorView<FlightStick> FlightSticks { get; }

    FlightStick FromGameController(IGameController gameController);
  }
}
