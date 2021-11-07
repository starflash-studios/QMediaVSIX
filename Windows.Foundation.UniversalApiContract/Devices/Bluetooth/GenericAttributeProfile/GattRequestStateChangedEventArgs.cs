// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattRequestStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class defines arguments of StateChanged.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  public sealed class GattRequestStateChangedEventArgs : IGattRequestStateChangedEventArgs
  {
    /// <summary>Gets the state of the read request.</summary>
    /// <returns>The state of the read request.</returns>
    public extern GattRequestState State { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth error.</summary>
    /// <returns>The Bluetooth error.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }
  }
}
