// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintMediaSize
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the media size option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintMediaSize
  {
    /// <summary>The default media size.</summary>
    Default,
    /// <summary>A media size that is not available with the application, or a size that is not supported by the print device.</summary>
    NotAvailable,
    /// <summary>A media size that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>A business card size.</summary>
    BusinessCard,
    /// <summary>A credit card size.</summary>
    CreditCard,
    /// <summary>The IsoA0 media size.</summary>
    IsoA0,
    /// <summary>The IsoA1 media size.</summary>
    IsoA1,
    /// <summary>The IsoA10 media size.</summary>
    IsoA10,
    /// <summary>The IsoA2 media size.</summary>
    IsoA2,
    /// <summary>The IsoA3 media size.</summary>
    IsoA3,
    /// <summary>The IsoA3Extra media size.</summary>
    IsoA3Extra,
    /// <summary>The IsoA3Rotated media size.</summary>
    IsoA3Rotated,
    /// <summary>The IsoA4 media size.</summary>
    IsoA4,
    /// <summary>The IsoA4Extra media size.</summary>
    IsoA4Extra,
    /// <summary>The IsoA4Rotated media size.</summary>
    IsoA4Rotated,
    /// <summary>The IsoA5 media size.</summary>
    IsoA5,
    /// <summary>The IsoA5Extra media size.</summary>
    IsoA5Extra,
    /// <summary>The IsoA5Rotated media size.</summary>
    IsoA5Rotated,
    /// <summary>The IsoA6 media size.</summary>
    IsoA6,
    /// <summary>The IsoA6Rotated media size.</summary>
    IsoA6Rotated,
    /// <summary>The IsoA7 media size.</summary>
    IsoA7,
    /// <summary>The IsoA8 media size.</summary>
    IsoA8,
    /// <summary>The IsoA9 media size.</summary>
    IsoA9,
    /// <summary>The IsoB0 media size.</summary>
    IsoB0,
    /// <summary>The IsoB1 media size.</summary>
    IsoB1,
    /// <summary>The IsoB10 media size.</summary>
    IsoB10,
    /// <summary>The IsoB2 media size.</summary>
    IsoB2,
    /// <summary>The IsoB3 media size.</summary>
    IsoB3,
    /// <summary>The IsoB4 media size.</summary>
    IsoB4,
    /// <summary>The IsoB4Envelope media size.</summary>
    IsoB4Envelope,
    /// <summary>The IsoB5Envelope media size.</summary>
    IsoB5Envelope,
    /// <summary>The IsoB5Extra media size.</summary>
    IsoB5Extra,
    /// <summary>The IsoB7 media size.</summary>
    IsoB7,
    /// <summary>The IsoB8 media size.</summary>
    IsoB8,
    /// <summary>The IsoB9 media size.</summary>
    IsoB9,
    /// <summary>The IsoC0 media size.</summary>
    IsoC0,
    /// <summary>The IsoC1 media size.</summary>
    IsoC1,
    /// <summary>The IsoC10 media size.</summary>
    IsoC10,
    /// <summary>The IsoC2 media size.</summary>
    IsoC2,
    /// <summary>The IsoC3 media size.</summary>
    IsoC3,
    /// <summary>The IsoC3Envelope media size.</summary>
    IsoC3Envelope,
    /// <summary>The IsoC4 media size.</summary>
    IsoC4,
    /// <summary>The IsoC4Envelope media size.</summary>
    IsoC4Envelope,
    /// <summary>The IsoC5 media size.</summary>
    IsoC5,
    /// <summary>The IsoC5Envelope media size.</summary>
    IsoC5Envelope,
    /// <summary>The IsoC6 media size.</summary>
    IsoC6,
    /// <summary>The IsoC6C5Envelope media size.</summary>
    IsoC6C5Envelope,
    /// <summary>The IsoC6Envelope media size.</summary>
    IsoC6Envelope,
    /// <summary>The IsoC7 media size.</summary>
    IsoC7,
    /// <summary>The IsoC8 media size.</summary>
    IsoC8,
    /// <summary>The IsoC9 media size.</summary>
    IsoC9,
    /// <summary>The IsoDLEnvelope media size.</summary>
    IsoDLEnvelope,
    /// <summary>The IsoDLEnvelopeRotated media size.</summary>
    IsoDLEnvelopeRotated,
    /// <summary>The IsoSRA3 media size.</summary>
    IsoSRA3,
    /// <summary>The Japan2LPhoto media size.</summary>
    Japan2LPhoto,
    /// <summary>The JapanChou3Envelope media size.</summary>
    JapanChou3Envelope,
    /// <summary>The JapanChou3EnvelopeRotated media size.</summary>
    JapanChou3EnvelopeRotated,
    /// <summary>The JapanChou4Envelope media size.</summary>
    JapanChou4Envelope,
    /// <summary>The JapanChou4EnvelopeRotated media size.</summary>
    JapanChou4EnvelopeRotated,
    /// <summary>The JapanChouDoubleHagakiPostcard media size.</summary>
    JapanDoubleHagakiPostcard,
    /// <summary>The JapanChouDoubleHagakiPostcardRotated media size.</summary>
    JapanDoubleHagakiPostcardRotated,
    /// <summary>The JapanHagakiPostcard media size.</summary>
    JapanHagakiPostcard,
    /// <summary>The JapanHagakiPostcardRotated media size.</summary>
    JapanHagakiPostcardRotated,
    /// <summary>The JapanKaku2Envelope media size.</summary>
    JapanKaku2Envelope,
    /// <summary>The JapanKaku2EnvelopeRotated media size.</summary>
    JapanKaku2EnvelopeRotated,
    /// <summary>The JapanKaku3Envelope media size.</summary>
    JapanKaku3Envelope,
    /// <summary>The JapanKaku3EnvelopeRotated media size.</summary>
    JapanKaku3EnvelopeRotated,
    /// <summary>The JapanlPhoto media size.</summary>
    JapanLPhoto,
    /// <summary>The JapanQuadrupleHagakiPostcard media size.</summary>
    JapanQuadrupleHagakiPostcard,
    /// <summary>The JapanYou1Envelope media size.</summary>
    JapanYou1Envelope,
    /// <summary>The JapanYou2Envelope media size.</summary>
    JapanYou2Envelope,
    /// <summary>The JapanYou3Envelope media size.</summary>
    JapanYou3Envelope,
    /// <summary>The JapanYou4Envelope media size.</summary>
    JapanYou4Envelope,
    /// <summary>The JapanYou4EnvelopeRotated media size.</summary>
    JapanYou4EnvelopeRotated,
    /// <summary>The JapanYou6Envelope media size.</summary>
    JapanYou6Envelope,
    /// <summary>The JapanYou6EnvelopeRotated media size.</summary>
    JapanYou6EnvelopeRotated,
    /// <summary>The JisB0 media size.</summary>
    JisB0,
    /// <summary>The JisB1 media size.</summary>
    JisB1,
    /// <summary>The JisB10 media size.</summary>
    JisB10,
    /// <summary>The JisB2 media size.</summary>
    JisB2,
    /// <summary>The JisB3 media size.</summary>
    JisB3,
    /// <summary>The JisB4 media size.</summary>
    JisB4,
    /// <summary>The JisB4 media size.</summary>
    JisB4Rotated,
    /// <summary>The JisB5 media size.</summary>
    JisB5,
    /// <summary>The JisB5Rotated media size.</summary>
    JisB5Rotated,
    /// <summary>The JisB6 media size.</summary>
    JisB6,
    /// <summary>The JisB6Rotated media size.</summary>
    JisB6Rotated,
    /// <summary>The JisB7 media size.</summary>
    JisB7,
    /// <summary>The JisB8 media size.</summary>
    JisB8,
    /// <summary>The JisB9 media size.</summary>
    JisB9,
    /// <summary>The NorthAmerica10x11 media size.</summary>
    NorthAmerica10x11,
    /// <summary>The NorthAmerica10x12 media size.</summary>
    NorthAmerica10x12,
    /// <summary>The NorthAmerica10x14 media size.</summary>
    NorthAmerica10x14,
    /// <summary>The NorthAmerica11x17 media size.</summary>
    NorthAmerica11x17,
    /// <summary>The NorthAmerica14x17 media size.</summary>
    NorthAmerica14x17,
    /// <summary>The NorthAmerica4x6 media size.</summary>
    NorthAmerica4x6,
    /// <summary>The NorthAmerica4x8 media size.</summary>
    NorthAmerica4x8,
    /// <summary>The NorthAmerica5x7 media size.</summary>
    NorthAmerica5x7,
    /// <summary>The NorthAmerica8x10 media size.</summary>
    NorthAmerica8x10,
    /// <summary>The NorthAmerica9x11 media size.</summary>
    NorthAmerica9x11,
    /// <summary>The NorthAmericaArchitectureASheet media size.</summary>
    NorthAmericaArchitectureASheet,
    /// <summary>The NorthAmericaArchitectureBSheet media size.</summary>
    NorthAmericaArchitectureBSheet,
    /// <summary>The NorthAmericaArchitectureCSheet media size.</summary>
    NorthAmericaArchitectureCSheet,
    /// <summary>The NorthAmericaArchitectureDSheet media size.</summary>
    NorthAmericaArchitectureDSheet,
    /// <summary>The NorthAmericaArchitectureESheet media size.</summary>
    NorthAmericaArchitectureESheet,
    /// <summary>The NorthAmericaCSheet media size.</summary>
    NorthAmericaCSheet,
    /// <summary>The NorthAmericaDSheet media size.</summary>
    NorthAmericaDSheet,
    /// <summary>The NorthAmericaESheet media sze.</summary>
    NorthAmericaESheet,
    /// <summary>The NorthAmericaExecutive media size.</summary>
    NorthAmericaExecutive,
    /// <summary>The NorthAmericaGermanLegalFanfold media size.</summary>
    NorthAmericaGermanLegalFanfold,
    /// <summary>The NorthAmericaGermanStandardFanfold media size.</summary>
    NorthAmericaGermanStandardFanfold,
    /// <summary>The NorthAmericaLegal media size.</summary>
    NorthAmericaLegal,
    /// <summary>The NorthAmericaLegalExtra media size.</summary>
    NorthAmericaLegalExtra,
    /// <summary>The NorthAmericaLetter media size.</summary>
    NorthAmericaLetter,
    /// <summary>The NorthAmericaLetterExtra media size.</summary>
    NorthAmericaLetterExtra,
    /// <summary>The NorthAmericaLetterPlus media size.</summary>
    NorthAmericaLetterPlus,
    /// <summary>The NorthAmericaLetterRotated media size.</summary>
    NorthAmericaLetterRotated,
    /// <summary>The NorthAmericaMonarchEnvelope media size.</summary>
    NorthAmericaMonarchEnvelope,
    /// <summary>The NorthAmericaNote media size.</summary>
    NorthAmericaNote,
    /// <summary>The NorthAmericaNumber10Envelope media size.</summary>
    NorthAmericaNumber10Envelope,
    /// <summary>The NorthAmericaNumber10EnvelopeRotated media size.</summary>
    NorthAmericaNumber10EnvelopeRotated,
    /// <summary>The NorthAmericaNumber11Envelope media size.</summary>
    NorthAmericaNumber11Envelope,
    /// <summary>The NorthAmericaNumber12Envelope media size.</summary>
    NorthAmericaNumber12Envelope,
    /// <summary>The NorthAmericaNumber14Envelope media size.</summary>
    NorthAmericaNumber14Envelope,
    /// <summary>The NorthAmericaNumber9Envelope media size.</summary>
    NorthAmericaNumber9Envelope,
    /// <summary>The NorthAmericaPersonalEnvelope media size.</summary>
    NorthAmericaPersonalEnvelope,
    /// <summary>The NorthAmericaQuarto media size.</summary>
    NorthAmericaQuarto,
    /// <summary>The NorthAmericaStatement media size.</summary>
    NorthAmericaStatement,
    /// <summary>The NorthAmericaSuperA media size.</summary>
    NorthAmericaSuperA,
    /// <summary>The NorthAmericaSuperB media size.</summary>
    NorthAmericaSuperB,
    /// <summary>The NorthAmericaTabloid media size.</summary>
    NorthAmericaTabloid,
    /// <summary>The NorthAmericaTabloidExtra media size.</summary>
    NorthAmericaTabloidExtra,
    /// <summary>The OtherMetricA3Plus media size.</summary>
    OtherMetricA3Plus,
    /// <summary>The OtherMetricA4Plus media size.</summary>
    OtherMetricA4Plus,
    /// <summary>The OtherMetricFolio media size.</summary>
    OtherMetricFolio,
    /// <summary>OtherMetricInviteEnvelope media size.</summary>
    OtherMetricInviteEnvelope,
    /// <summary>The OtherMetricItalianEnvelope media size.</summary>
    OtherMetricItalianEnvelope,
    /// <summary>The Prc10Envelope media size.</summary>
    Prc10Envelope,
    /// <summary>The Prc10EnvelopeRotated media size.</summary>
    Prc10EnvelopeRotated,
    /// <summary>The Prc16K media size.</summary>
    Prc16K,
    /// <summary>The Prc16KRotated media size.</summary>
    Prc16KRotated,
    /// <summary>The Prc1Envelope media size.</summary>
    Prc1Envelope,
    /// <summary>The Prc1EnvelopeRotated media size.</summary>
    Prc1EnvelopeRotated,
    /// <summary>The Prc2Envelope media size.</summary>
    Prc2Envelope,
    /// <summary>The Prc2EnvelopeRotated media size.</summary>
    Prc2EnvelopeRotated,
    /// <summary>The Prc32K media size.</summary>
    Prc32K,
    /// <summary>The Prc32KBig media size.</summary>
    Prc32KBig,
    /// <summary>The Prc32KRotated media size.</summary>
    Prc32KRotated,
    /// <summary>The Prc3Envelope media size.</summary>
    Prc3Envelope,
    /// <summary>The Prc3EnvelopeRotated media size.</summary>
    Prc3EnvelopeRotated,
    /// <summary>The Prc4Envelope media size.</summary>
    Prc4Envelope,
    /// <summary>The Prc4EnvelopeRotated media size.</summary>
    Prc4EnvelopeRotated,
    /// <summary>The Prc5Envelope media size.</summary>
    Prc5Envelope,
    /// <summary>The Prc5EnvelopeRotated media size.</summary>
    Prc5EnvelopeRotated,
    /// <summary>The Prc6Envelope media size.</summary>
    Prc6Envelope,
    /// <summary>The Prc6EnvelopeRotated media size.</summary>
    Prc6EnvelopeRotated,
    /// <summary>The Prc7Envelope media size.</summary>
    Prc7Envelope,
    /// <summary>The Prc7EnvelopeRotated media size.</summary>
    Prc7EnvelopeRotated,
    /// <summary>The Prc8Envelope media size.</summary>
    Prc8Envelope,
    /// <summary>The Prc8EnvelopeRotated media size.</summary>
    Prc8EnvelopeRotated,
    /// <summary>The Prc9Envelope media size.</summary>
    Prc9Envelope,
    /// <summary>The Prc9EnvelopeRotated media size.</summary>
    Prc9EnvelopeRotated,
    /// <summary>The Roll04Inch media size.</summary>
    Roll04Inch,
    /// <summary>The Roll06Inch media size.</summary>
    Roll06Inch,
    /// <summary>The Roll08Inch media size.</summary>
    Roll08Inch,
    /// <summary>The Roll12Inch media size.</summary>
    Roll12Inch,
    /// <summary>The Roll15Inch media size.</summary>
    Roll15Inch,
    /// <summary>The Roll18Inch media size.</summary>
    Roll18Inch,
    /// <summary>The Roll22Inch media size.</summary>
    Roll22Inch,
    /// <summary>The Roll24Inch media size.</summary>
    Roll24Inch,
    /// <summary>The Roll30Inch media size.</summary>
    Roll30Inch,
    /// <summary>The Roll36Inch media size.</summary>
    Roll36Inch,
    /// <summary>The Roll54Inch media size.</summary>
    Roll54Inch,
  }
}
