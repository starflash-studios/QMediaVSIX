// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RacingWheelReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Represents the current state of the racing wheel.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct RacingWheelReading
  {
    /// <summary>Time when the state was retrieved from the racing wheel.</summary>
    public ulong Timestamp;
    /// <summary>The state of the racing wheel buttons.</summary>
    public RacingWheelButtons Buttons;
    /// <summary>The gear the pattern shifter is in.</summary>
    public int PatternShifterGear;
    /// <summary>The angle of the wheel.</summary>
    public double Wheel;
    /// <summary>The position of the throttle.</summary>
    public double Throttle;
    /// <summary>The position of the brake.</summary>
    public double Brake;
    /// <summary>The position of the clutch.</summary>
    public double Clutch;
    /// <summary>The position of the handbrake.</summary>
    public double Handbrake;
  }
}
