// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides the American Association of Motor Vehicle Administrators (AAMVA) card data from the AamvaCardDataReceived event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MagneticStripeReaderAamvaCardDataReceivedEventArgs : 
    IMagneticStripeReaderAamvaCardDataReceivedEventArgs
  {
    /// <summary>Gets the additional data from the swiped AAMVA card.</summary>
    /// <returns>The report from the swiped AAMVA card.</returns>
    public extern MagneticStripeReaderReport Report { [MethodImpl] get; }

    /// <summary>Gets the license number from the swiped AAMVA card.</summary>
    /// <returns>The license number from the swiped AAMVA card.</returns>
    public extern string LicenseNumber { [MethodImpl] get; }

    /// <summary>Gets the expiration date from the swiped AAMVA card.</summary>
    /// <returns>The expiration date from the swiped AAMVA card.</returns>
    public extern string ExpirationDate { [MethodImpl] get; }

    /// <summary>Gets the restrictions from the swiped AAMVA card.</summary>
    /// <returns>The restrictions from the swiped AAMVA card.</returns>
    public extern string Restrictions { [MethodImpl] get; }

    /// <summary>Gets the class from the swiped AAMVA card.</summary>
    /// <returns>The class from the swiped AAMVA card.</returns>
    public extern string Class { [MethodImpl] get; }

    /// <summary>Gets the endorsements from the swiped AAMVA card.</summary>
    /// <returns>The endorsements from the swiped AAMVA card.</returns>
    public extern string Endorsements { [MethodImpl] get; }

    /// <summary>Gets the birth date from the swiped AAMVA card.</summary>
    /// <returns>The birth date from the swiped AAMVA card.</returns>
    public extern string BirthDate { [MethodImpl] get; }

    /// <summary>Gets the first name from the swiped AAMVA card.</summary>
    /// <returns>The first name from the swiped AAMVA card.</returns>
    public extern string FirstName { [MethodImpl] get; }

    /// <summary>Gets the surname from the swiped card.</summary>
    /// <returns>The surname from the swiped AAMVA card.</returns>
    public extern string Surname { [MethodImpl] get; }

    /// <summary>Gets the suffix from the swiped AAMVA card.</summary>
    /// <returns>The suffix from the swiped AAMVA card.</returns>
    public extern string Suffix { [MethodImpl] get; }

    /// <summary>Gets the gender from the swiped AAMVA card.</summary>
    /// <returns>The gender from the swiped AAMVA card.</returns>
    public extern string Gender { [MethodImpl] get; }

    /// <summary>Gets the hair color from the swiped AAMVA card.</summary>
    /// <returns>The hair color from the swiped AAMVA card.</returns>
    public extern string HairColor { [MethodImpl] get; }

    /// <summary>Gets the eye color from the swiped AAMVA card.</summary>
    /// <returns>The eye color from the swiped AAMVA card.</returns>
    public extern string EyeColor { [MethodImpl] get; }

    /// <summary>Gets the height from the swiped AAMVA card.</summary>
    /// <returns>The height from the swiped AAMVA card.</returns>
    public extern string Height { [MethodImpl] get; }

    /// <summary>Gets the weight from the swiped AAMVA card.</summary>
    /// <returns>The weight from the swiped AAMVA card.</returns>
    public extern string Weight { [MethodImpl] get; }

    /// <summary>Gets the address from the swiped AAMVA card.</summary>
    /// <returns>The address from the swiped AAMVA card.</returns>
    public extern string Address { [MethodImpl] get; }

    /// <summary>Gets the city from the swiped AAMVA card.</summary>
    /// <returns>The city from the swiped AAMVA card.</returns>
    public extern string City { [MethodImpl] get; }

    /// <summary>Gets the state from the swiped AAMVA card.</summary>
    /// <returns>The state from the swiped AAMVA card.</returns>
    public extern string State { [MethodImpl] get; }

    /// <summary>Gets the postal code from the swiped AAMVA card.</summary>
    /// <returns>The postal code from the swiped AAMVA card.</returns>
    public extern string PostalCode { [MethodImpl] get; }
  }
}
