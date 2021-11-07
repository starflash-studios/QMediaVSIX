// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.GamepadReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Represents the current state of the gamepad.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct GamepadReading
  {
    /// <summary>Time when the state was retrieved from the gamepad.</summary>
    public ulong Timestamp;
    /// <summary>The state of the gamepad's buttons. This will be a combination of values in the GamepadButtons enumeration.</summary>
    public GamepadButtons Buttons;
    /// <summary>The position of the left trigger. The value is between 0.0 (not depressed) and 1.0 (fully depressed).</summary>
    public double LeftTrigger;
    /// <summary>The position of the right trigger. The value is between 0.0 (not depressed) and 1.0 (fully depressed).</summary>
    public double RightTrigger;
    /// <summary>The position of the left thumbstick on the X-axis. The value is between -1.0 and 1.0.</summary>
    public double LeftThumbstickX;
    /// <summary>The position of the left thumbstick on the Y-axis. The value is between -1.0 and 1.0.</summary>
    public double LeftThumbstickY;
    /// <summary>The position of the right thumbstick on the X-axis. The value is between -1.0 and 1.0.</summary>
    public double RightThumbstickX;
    /// <summary>The position of the right thumbstick on the Y-axis. The value is between -1.0 and 1.0.</summary>
    public double RightThumbstickY;
  }
}
