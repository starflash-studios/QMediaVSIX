// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides the barcode data from the DataReceived event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerDataReceivedEventArgs : IBarcodeScannerDataReceivedEventArgs
  {
    /// <summary>Gets the data from the DataReceived event.</summary>
    /// <returns>Data from the barcode scanning event.</returns>
    public extern BarcodeScannerReport Report { [MethodImpl] get; }
  }
}
