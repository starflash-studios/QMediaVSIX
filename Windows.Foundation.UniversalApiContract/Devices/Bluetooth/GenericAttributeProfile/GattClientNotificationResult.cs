// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattClientNotificationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>The result of NotifyValueAsync</summary>
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattClientNotificationResult : 
    IGattClientNotificationResult,
    IGattClientNotificationResult2
  {
    /// <summary>Gets the subscribed client.</summary>
    /// <returns>The subscribed client.</returns>
    public extern GattSubscribedClient SubscribedClient { [MethodImpl] get; }

    /// <summary>Gets the GATT communication status.</summary>
    /// <returns>The GATT communication status.</returns>
    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the protocol error.</summary>
    /// <returns>The protocol error.</returns>
    public extern IReference<byte> ProtocolError { [MethodImpl] get; }

    /// <summary>Gets the bytes that were sent.</summary>
    /// <returns>The bytes that were sent.</returns>
    public extern ushort BytesSent { [MethodImpl] get; }
  }
}
