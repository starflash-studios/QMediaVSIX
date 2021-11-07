// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptorParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class defines the parameters of a descriptor.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattLocalDescriptorParameters : IGattLocalDescriptorParameters
  {
    /// <summary>Creates a new GattLocalDescriptorParameters object.</summary>
    [MethodImpl]
    public extern GattLocalDescriptorParameters();

    /// <summary>Gets or sets the static value.</summary>
    /// <returns>The static value.</returns>
    public extern IBuffer StaticValue { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the read protection level.</summary>
    /// <returns>The read protection level.</returns>
    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the write protection level.</summary>
    /// <returns>The write protection level.</returns>
    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] set; [MethodImpl] get; }
  }
}
