// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentMerchantInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class that contains information about a payment merchant.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentMerchantInfoFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentMerchantInfo : IPaymentMerchantInfo
  {
    [MethodImpl]
    public extern PaymentMerchantInfo(Uri uri);

    /// <summary>Creates a new PaymentMerchantInfo object.</summary>
    [MethodImpl]
    public extern PaymentMerchantInfo();

    /// <summary>The full name of the package.</summary>
    /// <returns>Gets or sets the PackageFullName.</returns>
    public extern string PackageFullName { [MethodImpl] get; }

    /// <summary>A read-only property containing the URI.</summary>
    /// <returns>Gets the Uri.</returns>
    public extern Uri Uri { [MethodImpl] get; }
  }
}
