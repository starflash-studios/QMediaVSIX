// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinResetHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents a method that handles a smart card personal identification number (PIN) reset.</summary>
  /// <param name="sender">An instance of an existing, configured physical smart card or Trusted Platform Module (TPM) virtual smart card.</param>
  /// <param name="request">An instance of a smart card PIN reset request.</param>
  [Guid(328031808, 62396, 19036, 180, 29, 75, 78, 246, 132, 226, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void SmartCardPinResetHandler(
    SmartCardProvisioning sender,
    SmartCardPinResetRequest request);
}
