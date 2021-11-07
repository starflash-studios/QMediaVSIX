// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentMethodData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class containing data about a payment method. This class reflects the W3C PaymentMethodData dictionary.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentMethodDataFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentMethodData : IPaymentMethodData
  {
    [MethodImpl]
    public extern PaymentMethodData(IIterable<string> supportedMethodIds);

    [MethodImpl]
    public extern PaymentMethodData(IIterable<string> supportedMethodIds, string jsonData);

    /// <summary>The supported method IDs.</summary>
    /// <returns>Gets the SupportedMethodIds.</returns>
    public extern IVectorView<string> SupportedMethodIds { [MethodImpl] get; }

    /// <summary>Data about the payment method. For example, if the Basic Card Payment method is being used then this must contain data confirming to the BasicCardRequest dictionary type.</summary>
    /// <returns>Gets the JsonData.</returns>
    public extern string JsonData { [MethodImpl] get; }
  }
}
