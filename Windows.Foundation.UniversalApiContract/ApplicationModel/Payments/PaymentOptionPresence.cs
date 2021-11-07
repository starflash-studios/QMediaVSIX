// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentOptionPresence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>An enumeration that indicates whether the option is required or optional.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PaymentOptionPresence
  {
    /// <summary>Property is not needed or used by the merchant.</summary>
    None,
    /// <summary>Property is not needed by the merchant, but they will accept it if provided. For example, a merchant could optionally send you a receipt to your email address.</summary>
    Optional,
    /// <summary>The merchant can't (or is unwilling to) process the transaction without this information.</summary>
    Required,
  }
}
