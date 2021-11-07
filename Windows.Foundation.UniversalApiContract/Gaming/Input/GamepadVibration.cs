// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.GamepadVibration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Describes the speed of the gamepad's four available vibration motors.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct GamepadVibration
  {
    /// <summary>The level of the left vibration motor. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.</summary>
    public double LeftMotor;
    /// <summary>The level of the right vibration motor. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.</summary>
    public double RightMotor;
    /// <summary>The left trigger vibration level. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.</summary>
    public double LeftTrigger;
    /// <summary>The right trigger vibration level. Valid values are between 0.0 and 1.0, where 0.0 signifies no motor use and 1.0 signifies max vibration.</summary>
    public double RightTrigger;
  }
}
