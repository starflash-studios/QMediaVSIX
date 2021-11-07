// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattSessionStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents the SessionStatusChanged event args.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattSessionStatusChangedEventArgs : IGattSessionStatusChangedEventArgs
  {
    /// <summary>Gets the error of the GATT session.</summary>
    /// <returns>The error of the GATT session.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>Gets the status of the GATT session.</summary>
    /// <returns>The status of the GATT session.</returns>
    public extern GattSessionStatus Status { [MethodImpl] get; }
  }
}
