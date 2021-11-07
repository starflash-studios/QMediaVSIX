// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentAddress))]
  [Guid(1596089577, 28474, 16742, 160, 24, 10, 11, 6, 187, 50, 181)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentAddress
  {
    string Country { get; set; }

    IVectorView<string> AddressLines { get; set; }

    string Region { get; set; }

    string City { get; set; }

    string DependentLocality { get; set; }

    string PostalCode { get; set; }

    string SortingCode { get; set; }

    string LanguageCode { get; set; }

    string Organization { get; set; }

    string Recipient { get; set; }

    string PhoneNumber { get; set; }

    ValueSet Properties { get; }
  }
}
