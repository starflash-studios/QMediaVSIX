// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardReaderKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents the smart card reader's type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmartCardReaderKind
  {
    /// <summary>This value is never returned.</summary>
    Any,
    /// <summary>A generic smart card reader.</summary>
    Generic,
    /// <summary>A Trusted Platform Module (TPM) virtual smart card reader.</summary>
    Tpm,
    /// <summary>A near field communication (NFC) smart card reader.</summary>
    Nfc,
    /// <summary>A Universal Integrated Circuit Card (UICC) smart card reader.</summary>
    Uicc,
    /// <summary>An embedded SE smart card reader.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EmbeddedSE,
  }
}
