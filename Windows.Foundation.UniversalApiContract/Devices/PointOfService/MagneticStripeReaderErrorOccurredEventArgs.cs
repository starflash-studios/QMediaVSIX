// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides error information for the ErrorOccurred event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderErrorOccurredEventArgs : 
    IMagneticStripeReaderErrorOccurredEventArgs
  {
    /// <summary>Gets the Track 1 error information.</summary>
    /// <returns>The Track 1 error information.</returns>
    public extern MagneticStripeReaderTrackErrorType Track1Status { [MethodImpl] get; }

    /// <summary>Gets the Track 2 error information.</summary>
    /// <returns>The Track 2 error information.</returns>
    public extern MagneticStripeReaderTrackErrorType Track2Status { [MethodImpl] get; }

    /// <summary>Gets the Track 3 error information.</summary>
    /// <returns>The Track 3 error information.</returns>
    public extern MagneticStripeReaderTrackErrorType Track3Status { [MethodImpl] get; }

    /// <summary>Gets the Track 4 error information.</summary>
    /// <returns>The Track 4 error information.</returns>
    public extern MagneticStripeReaderTrackErrorType Track4Status { [MethodImpl] get; }

    /// <summary>Gets the error information, such as cause of error, severity, error message, and any available vendor specific error information.</summary>
    /// <returns>The error information.</returns>
    public extern UnifiedPosErrorData ErrorData { [MethodImpl] get; }

    /// <summary>Gets the track data for tracks the did not have errors.</summary>
    /// <returns>The track data for tracks the did not have errors.</returns>
    public extern MagneticStripeReaderReport PartialInputData { [MethodImpl] get; }
  }
}
