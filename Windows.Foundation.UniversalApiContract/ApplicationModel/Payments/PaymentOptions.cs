// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class containing payment options. This class reflects the W3C PaymentOptions dictionary.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentOptions : IPaymentOptions
  {
    /// <summary>Creates a new PaymentOptions object.</summary>
    [MethodImpl]
    public extern PaymentOptions();

    /// <summary>Indicates whether to request the payer email.</summary>
    /// <returns>Gets or sets the RequestPayerEmail option.</returns>
    public extern PaymentOptionPresence RequestPayerEmail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether to request the payer name.</summary>
    /// <returns>Gets or sets the RequestPayerName.</returns>
    public extern PaymentOptionPresence RequestPayerName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether to request the payer phone number.</summary>
    /// <returns>Gets or sets the RequestPayerPhoneNumer.</returns>
    public extern PaymentOptionPresence RequestPayerPhoneNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether to request shipping. If this value is set to true, then PaymentDetails.ShippingOptions must not be empty.</summary>
    /// <returns>Gets or sets RequestShipping.</returns>
    public extern bool RequestShipping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The shipping type.</summary>
    /// <returns>Gets or sets the ShippingType.</returns>
    public extern PaymentShippingType ShippingType { [MethodImpl] get; [MethodImpl] set; }
  }
}
