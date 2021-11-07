// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRacingWheel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;

namespace Windows.Gaming.Input
{
  [Guid(4115031407, 57606, 19586, 169, 15, 85, 64, 18, 144, 75, 133)]
  [ExclusiveTo(typeof (RacingWheel))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRacingWheel : IGameController
  {
    bool HasClutch { get; }

    bool HasHandbrake { get; }

    bool HasPatternShifter { get; }

    int MaxPatternShifterGear { get; }

    double MaxWheelAngle { get; }

    ForceFeedbackMotor WheelMotor { get; }

    GameControllerButtonLabel GetButtonLabel(RacingWheelButtons button);

    RacingWheelReading GetCurrentReading();
  }
}
