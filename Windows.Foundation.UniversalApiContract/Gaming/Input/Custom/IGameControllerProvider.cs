// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Base interface that represents the physical game controller devices connected to the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3872864642, 10646, 17753, 177, 108, 62, 87, 212, 110, 88, 214)]
  public interface IGameControllerProvider
  {
    /// <summary>Contains information on the firmware version of the controller.</summary>
    /// <returns>Information on the firmware version of the controller.</returns>
    GameControllerVersionInfo FirmwareVersionInfo { get; }

    /// <summary>The hardware product ID of the controller.</summary>
    /// <returns>The hardware product ID of the controller.</returns>
    ushort HardwareProductId { get; }

    /// <summary>The hardware vendor ID of the controller.</summary>
    /// <returns>The hardware vendor ID of the controller.</returns>
    ushort HardwareVendorId { get; }

    /// <summary>Contains information on the hardware version.</summary>
    /// <returns>Information on the hardware version.</returns>
    GameControllerVersionInfo HardwareVersionInfo { get; }

    /// <summary>Boolean value indicating whether the controller is connected.</summary>
    /// <returns>Boolean value indicating whether the controller is connected.</returns>
    bool IsConnected { get; }
  }
}
