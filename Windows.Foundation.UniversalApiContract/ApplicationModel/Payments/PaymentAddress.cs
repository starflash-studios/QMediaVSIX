// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class represents an address that is used in the Payment Request API. This class reflects the W3C PaymentAddress interface.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentAddress : IPaymentAddress
  {
    /// <summary>Creates a new PaymentAddress object.</summary>
    [MethodImpl]
    public extern PaymentAddress();

    /// <summary>The country. Values must be from the CLDR standard.</summary>
    /// <returns>Gets or sets the Country.</returns>
    public extern string Country { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The address lines.</summary>
    /// <returns>Gets or sets the AddressLines.</returns>
    public extern IVectorView<string> AddressLines { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The region of a country.</summary>
    /// <returns>Gets or sets the Region.</returns>
    public extern string Region { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The city.</summary>
    /// <returns>Gets or sets the City.</returns>
    public extern string City { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The dependent locality within a city.</summary>
    /// <returns>Gets or sets the DependentLocality.</returns>
    public extern string DependentLocality { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The address postal code.</summary>
    /// <returns>Gets or sets the PostalCode.</returns>
    public extern string PostalCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The sorting code.</summary>
    /// <returns>Gets or sets the SortingCode.</returns>
    public extern string SortingCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Language code for the address. Values must be valid IETF language tags as specified by the BCP-47 standard.</summary>
    /// <returns>Gets or sets the LanguageCode.</returns>
    public extern string LanguageCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Organization in the address.</summary>
    /// <returns>Gets or sets the Organization.</returns>
    public extern string Organization { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The name of the recipient.</summary>
    /// <returns>Gets or sets the Recipient.</returns>
    public extern string Recipient { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The phone number of the recipient.</summary>
    /// <returns>Gets or sets the PhoneNumber.</returns>
    public extern string PhoneNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This field is used to allow extensions to the class. It is not present in the W3C definition.</summary>
    /// <returns>Gets or sets Properties.</returns>
    public extern ValueSet Properties { [MethodImpl] get; }
  }
}
