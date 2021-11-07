// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptorsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>The result of descriptor operations like GattCharacteristic.GetDescriptorsAsync</summary>
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattDescriptorsResult : IGattDescriptorsResult
  {
    /// <summary>Gets the status of the operation.</summary>
    /// <returns>The status of the operation.</returns>
    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the GATT protocol error.</summary>
    /// <returns>The GATT protocol error.</returns>
    public extern IReference<byte> ProtocolError { [MethodImpl] get; }

    /// <summary>Gets a vector of the GATT descriptors.</summary>
    /// <returns>A vector of the GATT descriptors.</returns>
    public extern IVectorView<GattDescriptor> Descriptors { [MethodImpl] get; }
  }
}
