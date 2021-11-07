// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadClientCharacteristicConfigurationDescriptorResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents the result of reading a GATT Client CharacteristicConfigurationClientDescriptor value.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattReadClientCharacteristicConfigurationDescriptorResult : 
    IGattReadClientCharacteristicConfigurationDescriptorResult,
    IGattReadClientCharacteristicConfigurationDescriptorResult2
  {
    /// <summary>Gets the status of an asynchronous operation.</summary>
    /// <returns>The status of the asynchronous operation.</returns>
    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the result of an asynchronous read operation.</summary>
    /// <returns>The result of the asynchronous read operation.</returns>
    public extern GattClientCharacteristicConfigurationDescriptorValue ClientCharacteristicConfigurationDescriptor { [MethodImpl] get; }

    /// <summary>Gets the protocol error.</summary>
    /// <returns>The protocol error.</returns>
    public extern IReference<byte> ProtocolError { [MethodImpl] get; }
  }
}
