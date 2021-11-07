// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class defines a descriptor of a local characteristic.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class GattLocalDescriptor : IGattLocalDescriptor
  {
    /// <summary>Gets the Bluetooth SIG-defined UUID for this local characteristic descriptor.</summary>
    /// <returns>The Bluetooth SIG-defined UUID for this local characteristic descriptor.</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Gets the static value for this local characteristic descriptor.</summary>
    /// <returns>The static value for this local characteristic descriptor.</returns>
    public extern IBuffer StaticValue { [MethodImpl] get; }

    /// <summary>Gets the read protection level of this local characteristic descriptor.</summary>
    /// <returns>The read protection level of this local characteristic descriptor.</returns>
    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] get; }

    /// <summary>Gets the write protection level.</summary>
    /// <returns>The write protection level.</returns>
    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] get; }

    /// <summary>An event that is triggered when a read has been requested.</summary>
    public extern event TypedEventHandler<GattLocalDescriptor, GattReadRequestedEventArgs> ReadRequested;

    /// <summary>An event that is triggered when a write has been requested.</summary>
    public extern event TypedEventHandler<GattLocalDescriptor, GattWriteRequestedEventArgs> WriteRequested;
  }
}
