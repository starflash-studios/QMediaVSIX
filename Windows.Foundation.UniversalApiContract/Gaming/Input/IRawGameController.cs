// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRawGameController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (RawGameController))]
  [Guid(2091740561, 42977, 20337, 154, 120, 51, 233, 197, 223, 234, 98)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRawGameController : IGameController
  {
    int AxisCount { get; }

    int ButtonCount { get; }

    IVectorView<ForceFeedbackMotor> ForceFeedbackMotors { get; }

    ushort HardwareProductId { get; }

    ushort HardwareVendorId { get; }

    int SwitchCount { get; }

    GameControllerButtonLabel GetButtonLabel(int buttonIndex);

    ulong GetCurrentReading(
      [Out] bool[] buttonArray,
      [Out] GameControllerSwitchPosition[] switchArray,
      [Out] double[] axisArray);

    GameControllerSwitchKind GetSwitchKind(int switchIndex);
  }
}
