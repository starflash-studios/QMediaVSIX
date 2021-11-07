// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides data for the ErrorOccurred event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerErrorOccurredEventArgs : IBarcodeScannerErrorOccurredEventArgs
  {
    /// <summary>Gets any data that was successfully read.</summary>
    /// <returns>The partial input information from the barcode scanner.</returns>
    public extern BarcodeScannerReport PartialInputData { [MethodImpl] get; }

    /// <summary>Indicates whether it is worthwhile to make another attempt at the operation.</summary>
    /// <returns>True if the application should make another attempt at the operation; otherwise, false.</returns>
    public extern bool IsRetriable { [MethodImpl] get; }

    /// <summary>Gets the data associated with the ErrorOccurred event.</summary>
    /// <returns>The error information.</returns>
    public extern UnifiedPosErrorData ErrorData { [MethodImpl] get; }
  }
}
