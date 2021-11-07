// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.XusbGameControllerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Represents the physical game controller devices connected to the system using XUSB22.SYS (for Xbox 360 accessories).</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  public sealed class XusbGameControllerProvider : 
    IXusbGameControllerProvider,
    IGameControllerProvider
  {
    /// <summary>Sets the speed on the controller's vibration motor.</summary>
    /// <param name="lowFrequencyMotorSpeed">The low frequency motor speed.</param>
    /// <param name="highFrequencyMotorSpeed">The high frequency motor speed.</param>
    [MethodImpl]
    public extern void SetVibration(double lowFrequencyMotorSpeed, double highFrequencyMotorSpeed);

    /// <summary>The firmware version of the controller.</summary>
    /// <returns>The firmware version of the controller.</returns>
    public extern GameControllerVersionInfo FirmwareVersionInfo { [MethodImpl] get; }

    /// <summary>The hardware product ID of the controller.</summary>
    /// <returns>The hardware product ID of the controller.</returns>
    public extern ushort HardwareProductId { [MethodImpl] get; }

    /// <summary>The hardware vendor ID of the controller.</summary>
    /// <returns>The hardware vendor ID of the controller.</returns>
    public extern ushort HardwareVendorId { [MethodImpl] get; }

    /// <summary>Contains information on the hardware version of the controller.</summary>
    /// <returns>Information on the hardware version of the controller.</returns>
    public extern GameControllerVersionInfo HardwareVersionInfo { [MethodImpl] get; }

    /// <summary>Boolean indicating whether the controller is connected.</summary>
    /// <returns>Boolean indicating whether the controller is connected.</returns>
    public extern bool IsConnected { [MethodImpl] get; }
  }
}
