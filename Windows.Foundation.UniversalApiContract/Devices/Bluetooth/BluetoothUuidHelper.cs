// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothUuidHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>A helper class that provides methods to convert between bluetooth device UUID and short ID.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IBluetoothUuidHelperStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class BluetoothUuidHelper
  {
    /// <summary>Returns the bluetooth device UUID from a short ID.</summary>
    /// <param name="shortId">The short ID.</param>
    /// <returns>Returns the UUID.</returns>
    [MethodImpl]
    public static extern Guid FromShortId(uint shortId);

    /// <summary>Attempts to get the short bluetooth device ID from a UUID.</summary>
    /// <param name="uuid">The UUID.</param>
    /// <returns>Returns the short ID.</returns>
    [MethodImpl]
    public static extern IReference<uint> TryGetShortId(Guid uuid);
  }
}
