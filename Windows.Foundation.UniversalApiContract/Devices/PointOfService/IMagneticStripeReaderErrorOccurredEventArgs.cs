// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReaderErrorOccurredEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(535689565, 11396, 16813, 183, 120, 242, 53, 106, 120, 154, 177)]
  internal interface IMagneticStripeReaderErrorOccurredEventArgs
  {
    MagneticStripeReaderTrackErrorType Track1Status { get; }

    MagneticStripeReaderTrackErrorType Track2Status { get; }

    MagneticStripeReaderTrackErrorType Track3Status { get; }

    MagneticStripeReaderTrackErrorType Track4Status { get; }

    UnifiedPosErrorData ErrorData { get; }

    MagneticStripeReaderReport PartialInputData { get; }
  }
}
