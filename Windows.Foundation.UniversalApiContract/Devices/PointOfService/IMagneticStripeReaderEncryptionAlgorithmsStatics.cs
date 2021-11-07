// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderEncryptionAlgorithmsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1404400464, 50139, 18260, 156, 0, 65, 57, 35, 116, 161, 9)]
  [ExclusiveTo(typeof (MagneticStripeReaderEncryptionAlgorithms))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderEncryptionAlgorithmsStatics
  {
    uint None { get; }

    uint TripleDesDukpt { get; }

    uint ExtendedBase { get; }
  }
}
