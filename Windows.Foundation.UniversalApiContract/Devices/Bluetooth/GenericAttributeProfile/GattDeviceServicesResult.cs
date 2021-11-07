// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceServicesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>The status of GetIncludedServicesForUuidAsync and GetIncludedServicesForUuidAsync</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 1)]
  public sealed class GattDeviceServicesResult : IGattDeviceServicesResult
  {
    /// <summary>Gets the communication status of the operation.</summary>
    /// <returns>The communication status of the operation.</returns>
    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the protocol error.</summary>
    /// <returns>The protocol error.</returns>
    public extern IReference<byte> ProtocolError { [MethodImpl] get; }

    /// <summary>Gets the services.</summary>
    /// <returns>The services.</returns>
    public extern IVectorView<GattDeviceService> Services { [MethodImpl] get; }
  }
}
