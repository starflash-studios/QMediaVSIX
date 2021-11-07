// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGameControllerBatteryInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Interface that allows game controller (or headset) classes to query for information about the current battery state, regardless of their actual type (gamepad, racing wheel, flight stick, and so on).</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3706504833, 14691, 19878, 149, 93, 85, 63, 59, 111, 97, 97)]
  public interface IGameControllerBatteryInfo
  {
    /// <summary>Gets information about the game controller's current battery state.</summary>
    /// <returns>Information about the game controller's current battery state.</returns>
    BatteryReport TryGetBatteryReport();
  }
}
