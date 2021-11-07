// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderTrackData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Guid(273479281, 19101, 17518, 171, 197, 32, 64, 35, 7, 186, 54)]
  [ExclusiveTo(typeof (MagneticStripeReaderTrackData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderTrackData
  {
    IBuffer Data { get; }

    IBuffer DiscretionaryData { get; }

    IBuffer EncryptedData { get; }
  }
}
