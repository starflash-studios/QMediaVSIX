// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents a Generic Attribute Profile (GATT) session.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattSessionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattSession : IGattSession, IClosable
  {
    /// <summary>Gets the device ID.</summary>
    /// <returns>The device ID.</returns>
    public extern BluetoothDeviceId DeviceId { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the connection can be maintained.</summary>
    /// <returns>`true` if the connection can be maintained, otherwise `false`.</returns>
    public extern bool CanMaintainConnection { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value that indicates whether the connection should be maintained.</summary>
    /// <returns>`true` if the connection should be maintained, otherwise `false`.</returns>
    public extern bool MaintainConnection { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the max PDU size.</summary>
    /// <returns>The max PDU size.</returns>
    public extern ushort MaxPduSize { [MethodImpl] get; }

    /// <summary>Gets the session status.</summary>
    /// <returns>The session status.</returns>
    public extern GattSessionStatus SessionStatus { [MethodImpl] get; }

    /// <summary>An event that is triggered when the max PDU size changes.</summary>
    public extern event TypedEventHandler<GattSession, object> MaxPduSizeChanged;

    /// <summary>An event that is triggered when the GATT session status has changed.</summary>
    public extern event TypedEventHandler<GattSession, GattSessionStatusChangedEventArgs> SessionStatusChanged;

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a new GattSession object from the specified deviceId.</summary>
    /// <param name="deviceId">The deviceId.</param>
    /// <returns>An asynchronous operation that completes with a new GattSession object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattSession> FromDeviceIdAsync(
      BluetoothDeviceId deviceId);
  }
}
