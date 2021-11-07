// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristicParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class contains the local characteristic descriptor parameters.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattLocalCharacteristicParameters : IGattLocalCharacteristicParameters
  {
    /// <summary>Creates a new GattLocalCharacteristicParameters object.</summary>
    [MethodImpl]
    public extern GattLocalCharacteristicParameters();

    /// <summary>Gets or sets the static value.</summary>
    /// <returns>The static value.</returns>
    public extern IBuffer StaticValue { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the properties.</summary>
    /// <returns>The properties.</returns>
    public extern GattCharacteristicProperties CharacteristicProperties { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the read protection level.</summary>
    /// <returns>The read protection level.</returns>
    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets and sets the write protection level.</summary>
    /// <returns>The write protection level.</returns>
    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the user-friendly description.</summary>
    /// <returns>The user-friendly description.</returns>
    public extern string UserDescription { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the presentation formats.</summary>
    /// <returns>The presentation formats.</returns>
    public extern IVector<GattPresentationFormat> PresentationFormats { [MethodImpl] get; }
  }
}
