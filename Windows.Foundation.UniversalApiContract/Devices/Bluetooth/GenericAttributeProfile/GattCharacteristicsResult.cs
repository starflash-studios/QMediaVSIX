// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristicsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Contains the result of GetCharacteristicsForUuidAsync and GetCharacteristicsAsync</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class GattCharacteristicsResult : IGattCharacteristicsResult
  {
    /// <summary>Gets the status.</summary>
    /// <returns>The status.</returns>
    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the protocol error, if there is one.</summary>
    /// <returns>The protocol error.</returns>
    public extern IReference<byte> ProtocolError { [MethodImpl] get; }

    /// <summary>Gets the characterisitics.</summary>
    /// <returns>The characteristics.</returns>
    public extern IVectorView<GattCharacteristic> Characteristics { [MethodImpl] get; }
  }
}
