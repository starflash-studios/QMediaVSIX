// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.FlightStickReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>The current state of the flight stick.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct FlightStickReading
  {
    /// <summary>The time that the reading was reported from the hardware.</summary>
    public ulong Timestamp;
    /// <summary>The button currently being pressed.</summary>
    public FlightStickButtons Buttons;
    /// <summary>The position of the hat switch.</summary>
    public GameControllerSwitchPosition HatSwitch;
    /// <summary>The amount of roll (rotation around the Z-axis; left and right movement on the flight stick).</summary>
    public double Roll;
    /// <summary>The amount of pitch (rotation around the X-axis; forward and backward movement on the flight stick).</summary>
    public double Pitch;
    /// <summary>The amount of yaw (rotation around the Y-axis; usually read from twisting the joystick or from some other input).</summary>
    public double Yaw;
    /// <summary>The position of the throttle.</summary>
    public double Throttle;
  }
}
