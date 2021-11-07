// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderCardTypesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1385114717, 10630, 18255, 132, 84, 124, 205, 5, 146, 141, 95)]
  [ExclusiveTo(typeof (MagneticStripeReaderCardTypes))]
  internal interface IMagneticStripeReaderCardTypesStatics
  {
    uint Unknown { get; }

    uint Bank { get; }

    uint Aamva { get; }

    uint ExtendedBase { get; }
  }
}
