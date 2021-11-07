// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderAamvaCardDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReaderAamvaCardDataReceivedEventArgs))]
  [Guid(172735825, 49942, 18704, 135, 243, 122, 98, 186, 134, 45, 49)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReaderAamvaCardDataReceivedEventArgs
  {
    MagneticStripeReaderReport Report { get; }

    string LicenseNumber { get; }

    string ExpirationDate { get; }

    string Restrictions { get; }

    string Class { get; }

    string Endorsements { get; }

    string BirthDate { get; }

    string FirstName { get; }

    string Surname { get; }

    string Suffix { get; }

    string Gender { get; }

    string HairColor { get; }

    string EyeColor { get; }

    string Height { get; }

    string Weight { get; }

    string Address { get; }

    string City { get; }

    string State { get; }

    string PostalCode { get; }
  }
}
