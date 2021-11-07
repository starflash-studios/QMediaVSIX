// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipGameControllerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Represents a physical game controller connected to the system using GIP.SYS (for Xbox One accesories).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class GipGameControllerProvider : IGipGameControllerProvider, IGameControllerProvider
  {
    /// <summary>Sends a message.</summary>
    /// <param name="messageClass">The class of the message.</param>
    /// <param name="messageId">The ID of the message.</param>
    /// <param name="messageBuffer">A buffer holding the message contents.</param>
    [MethodImpl]
    public extern void SendMessage(
      GipMessageClass messageClass,
      byte messageId,
      byte[] messageBuffer);

    /// <summary>Sends a request for a message.</summary>
    /// <param name="messageClass">The class of the message.</param>
    /// <param name="messageId">The ID of the message.</param>
    /// <param name="requestMessageBuffer">A buffer containing the request.</param>
    /// <param name="responseMessageBuffer">A buffer that will contain the request response.</param>
    [MethodImpl]
    public extern void SendReceiveMessage(
      GipMessageClass messageClass,
      byte messageId,
      byte[] requestMessageBuffer,
      [Out] byte[] responseMessageBuffer);

    /// <summary>Attempts to asynchronously update the firmware for the controller.</summary>
    /// <param name="firmwareImage">A stream pointing to the firmware image with which to update the controller.</param>
    /// <returns>Returns the result of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<GipFirmwareUpdateResult, GipFirmwareUpdateProgress> UpdateFirmwareAsync(
      IInputStream firmwareImage);

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
    /// <returns>Contains information on the hardware version of the controller.</returns>
    public extern GameControllerVersionInfo HardwareVersionInfo { [MethodImpl] get; }

    /// <summary>Boolean value indicating whether the controller is connected.</summary>
    /// <returns>Boolean value indicating whether the controller is connected.</returns>
    public extern bool IsConnected { [MethodImpl] get; }
  }
}
