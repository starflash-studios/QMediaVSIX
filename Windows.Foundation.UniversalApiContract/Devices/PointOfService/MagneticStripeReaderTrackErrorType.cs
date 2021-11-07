// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderTrackErrorType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates the track error type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MagneticStripeReaderTrackErrorType
  {
    /// <summary>An unknown error.</summary>
    Unknown = -1, // 0xFFFFFFFF
    /// <summary>No specified error.</summary>
    None = 0,
    /// <summary>A start sentinel error.</summary>
    StartSentinelError = 1,
    /// <summary>An end sentinel error.</summary>
    EndSentinelError = 2,
    /// <summary>A parity error.</summary>
    ParityError = 3,
    /// <summary>An LRC error.</summary>
    LrcError = 4,
  }
}
