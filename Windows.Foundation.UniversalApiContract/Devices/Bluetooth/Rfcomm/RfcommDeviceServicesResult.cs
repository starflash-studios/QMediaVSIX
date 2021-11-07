// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceServicesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  /// <summary>The result of an Rfcomm device service request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RfcommDeviceServicesResult : IRfcommDeviceServicesResult
  {
    /// <summary>Indicates that an error occurred.</summary>
    /// <returns>Gets the error property.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>The RfcommDeviceService object.</summary>
    /// <returns>Gets the RfcommDeviceService object.</returns>
    public extern IVectorView<RfcommDeviceService> Services { [MethodImpl] get; }
  }
}
