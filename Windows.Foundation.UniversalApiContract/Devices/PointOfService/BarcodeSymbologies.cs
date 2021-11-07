// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeSymbologies
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Contains the barcode symbology.</summary>
  [Static(typeof (IBarcodeSymbologiesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBarcodeSymbologiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class BarcodeSymbologies
  {
    /// <summary>Gets the GS1DWCode barcode symbology.</summary>
    /// <returns>The GS1DWCode barcode symbology.</returns>
    public static extern uint Gs1DWCode { [MethodImpl] get; }

    /// <summary>Unknown barcode symbology.</summary>
    /// <returns>Unknown barcode symbology.</returns>
    public static extern uint Unknown { [MethodImpl] get; }

    /// <summary>Gets the EAN 8 barcode symbology.</summary>
    /// <returns>The EAN 8 barcode symbology.</returns>
    public static extern uint Ean8 { [MethodImpl] get; }

    /// <summary>Gets the EAN 8 with 2 digit supplement barcode symbology.</summary>
    /// <returns>The EAN 8 with 2 digit supplement barcode symbology.</returns>
    public static extern uint Ean8Add2 { [MethodImpl] get; }

    /// <summary>Gets the EAN 8 with 5 digit supplement barcode symbology.</summary>
    /// <returns>The EAN 8 with 5 digit supplement barcode symbology.</returns>
    public static extern uint Ean8Add5 { [MethodImpl] get; }

    /// <summary>Gets the EAN Velocity barcode symbology.</summary>
    /// <returns>The EAN Velocity barcode symbology.</returns>
    public static extern uint Eanv { [MethodImpl] get; }

    /// <summary>Gets the EAN Velocity with 2 digit supplement barcode symbology.</summary>
    /// <returns>The EAN Velocity with 2 digit supplement barcode symbology.</returns>
    public static extern uint EanvAdd2 { [MethodImpl] get; }

    /// <summary>Gets the EAN Velocity with 5 digit supplement barcode symbology.</summary>
    /// <returns>The EAN Velocity with 5 digit supplement barcode symbology.</returns>
    public static extern uint EanvAdd5 { [MethodImpl] get; }

    /// <summary>Gets the EAN (European Article Number) 13 barcode symbology.</summary>
    /// <returns>The EAN 13 barcode symbology.</returns>
    public static extern uint Ean13 { [MethodImpl] get; }

    /// <summary>Gets the EAN 13 with 2 digit supplement barcode symbology.</summary>
    /// <returns>The EAN 13 with 2 digit supplement barcode symbology.</returns>
    public static extern uint Ean13Add2 { [MethodImpl] get; }

    /// <summary>Gets the EAN 13 with 5 digit supplement barcode symbology.</summary>
    /// <returns>The EAN 13 with 5 digit supplement barcode symbology.</returns>
    public static extern uint Ean13Add5 { [MethodImpl] get; }

    /// <summary>Gets the International Standard Book Number (ISBN), also known as Bookland or Bookland EAN, barcode symbology.</summary>
    /// <returns>The International Standard Book Number (ISBN), also known as Bookland or Bookland EAN, barcode symbology.</returns>
    public static extern uint Isbn { [MethodImpl] get; }

    /// <summary>Gets the ISBN with 5 digit supplement barcode symbology.</summary>
    /// <returns>The ISBN with 5 digit supplement barcode symbology.</returns>
    public static extern uint IsbnAdd5 { [MethodImpl] get; }

    /// <summary>Gets the International Standard Music Number (ISMN) barcode symbology.</summary>
    /// <returns>The International Standard Music Number (ISMN) barcode symbology.</returns>
    public static extern uint Ismn { [MethodImpl] get; }

    /// <summary>Gets the ISMN with 2 digit supplement barcode symbology.</summary>
    /// <returns>The ISMN with 2 digit supplement barcode symbology.</returns>
    public static extern uint IsmnAdd2 { [MethodImpl] get; }

    /// <summary>Gets the ISMN with 5 digit supplement barcode symbology.</summary>
    /// <returns>The ISMN with 5 digit supplement barcode symbology.</returns>
    public static extern uint IsmnAdd5 { [MethodImpl] get; }

    /// <summary>Gets the International Standard Serial Number (ISSN) barcode symbology.</summary>
    /// <returns>The International Standard Serial Number (ISSN) barcode symbology.</returns>
    public static extern uint Issn { [MethodImpl] get; }

    /// <summary>Gets the ISSN with 2 digit supplement barcode symbology.</summary>
    /// <returns>The ISMN with 2 digit supplement barcode symbology.</returns>
    public static extern uint IssnAdd2 { [MethodImpl] get; }

    /// <summary>Gets the ISSN with 5 digit supplement barcode symbology.</summary>
    /// <returns>The ISSN with 5 digit supplement barcode symbology.</returns>
    public static extern uint IssnAdd5 { [MethodImpl] get; }

    /// <summary>Gets the EAN 99 barcode symbology.</summary>
    /// <returns>The EAN 99 barcode symbology.</returns>
    public static extern uint Ean99 { [MethodImpl] get; }

    /// <summary>Gets the EAN 99 with 2 digit supplement barcode symbology.</summary>
    /// <returns>The EAN 99 with 2 digit supplement barcode symbology.</returns>
    public static extern uint Ean99Add2 { [MethodImpl] get; }

    /// <summary>Gets the EAN 99 with 5 digit supplement barcode symbology.</summary>
    /// <returns>The EAN 99 with 5 digit supplementbarcode symbology.</returns>
    public static extern uint Ean99Add5 { [MethodImpl] get; }

    /// <summary>Gets the Universal Product Code (UPC) version A barcode symbology.</summary>
    /// <returns>The Universal Product Code (UPC) version A barcode symbology.</returns>
    public static extern uint Upca { [MethodImpl] get; }

    /// <summary>Gets the UPC A with 2 digit supplemental barcode symbology.</summary>
    /// <returns>The UPC A with 2 digit supplemental barcode symbology.</returns>
    public static extern uint UpcaAdd2 { [MethodImpl] get; }

    /// <summary>Gets the UPC A with 5 digit supplement barcode symbology.</summary>
    /// <returns>The UPC A with 5 digit supplement barcode symbology.</returns>
    public static extern uint UpcaAdd5 { [MethodImpl] get; }

    /// <summary>Gets the Universal Product Code (UPC) version E barcode symbology.</summary>
    /// <returns>The Universal Product Code (UPC) version E barcode symbology.</returns>
    public static extern uint Upce { [MethodImpl] get; }

    /// <summary>Gets the UPC-E with 2 digit supplemnent barcode symbology.</summary>
    /// <returns>The UPC-E with 2 digit supplemnent barcode symbology.</returns>
    public static extern uint UpceAdd2 { [MethodImpl] get; }

    /// <summary>Gets the UPC-E with 5 digit supplement barcode symbology.</summary>
    /// <returns>The UPC-E with 5 digit supplement barcode symbology.</returns>
    public static extern uint UpceAdd5 { [MethodImpl] get; }

    /// <summary>Gets the UPC Coupon with supplemental barcode symbology.</summary>
    /// <returns>The UPC Coupon with supplemental barcode symbology.</returns>
    public static extern uint UpcCoupon { [MethodImpl] get; }

    /// <summary>Gets the Standard 2 of 5 barcode symbology.</summary>
    /// <returns>The Standard 2 of 5 barcode symbology.</returns>
    public static extern uint TfStd { [MethodImpl] get; }

    /// <summary>Gets the Discreet 2 of 5 barcode symbology.</summary>
    /// <returns>The Discreet 2 of 5 barcode symbology.</returns>
    public static extern uint TfDis { [MethodImpl] get; }

    /// <summary>Gets the Interleaved 2 of 5 barcode symbology.</summary>
    /// <returns>The Interleaved 2 of 5 barcode symbology.</returns>
    public static extern uint TfInt { [MethodImpl] get; }

    /// <summary>Gets the Industrial 2 of 5 barcode symbology.</summary>
    /// <returns>The Industrial 2 of 5 barcode symbology.</returns>
    public static extern uint TfInd { [MethodImpl] get; }

    /// <summary>Gets the 2 of 5 Matrix barcode symbology.</summary>
    /// <returns>The 2 of 5 Matrix barcode symbology.</returns>
    public static extern uint TfMat { [MethodImpl] get; }

    /// <summary>Gets the 2 of 5 International Air Transportation Association (IATA) barcode symbology.</summary>
    /// <returns>The 2 of 5 International Air Transportation Association (IATA) barcode symbology.</returns>
    public static extern uint TfIata { [MethodImpl] get; }

    /// <summary>Gets the GS1 Databar Omnidirectional, GS1 Databar Stacked Omnidirectional, GS1 Databar Stacked, or GS1 Databar Truncated barcode symbology.</summary>
    /// <returns>The GS1 Databar Omnidirectional, GS1 Databar Stacked Omnidirectional, GS1 Databar Stacked, or GS1 Databar Truncated barcode symbology.</returns>
    public static extern uint Gs1DatabarType1 { [MethodImpl] get; }

    /// <summary>Gets the GS1 DataBar Limited or RSS Limited barcode symbology.</summary>
    /// <returns>The GS1 DataBar Limited or RSS Limited barcode symbology.</returns>
    public static extern uint Gs1DatabarType2 { [MethodImpl] get; }

    /// <summary>Gets the GS1 Databar Expanded, GS1 Databar Expanded Stacked, or RSS Expanded barcode symbology.</summary>
    /// <returns>The GS1 Databar Expanded, GS1 Databar Expanded Stacked, or RSS Expanded barcode symbology.</returns>
    public static extern uint Gs1DatabarType3 { [MethodImpl] get; }

    /// <summary>Gets the Code 39 barcode symbology.</summary>
    /// <returns>The Code 39 barcode symbology.</returns>
    public static extern uint Code39 { [MethodImpl] get; }

    /// <summary>Gets the Code 39 Extended barcode symbology.</summary>
    /// <returns>The Code 39 Extended barcode symbology.</returns>
    public static extern uint Code39Ex { [MethodImpl] get; }

    /// <summary>Gets the Tri-Optic Media Storage Devices barcode symbology.</summary>
    /// <returns>The Tri-Optic Media Storage Devices barcode symbology.</returns>
    public static extern uint Trioptic39 { [MethodImpl] get; }

    /// <summary>Gets the Code 32 barcode symbology.</summary>
    /// <returns>The Code 32 barcode symbology.</returns>
    public static extern uint Code32 { [MethodImpl] get; }

    /// <summary>Gets the Pharma-Zentral-Nummer (Pzn) barcode symbology.</summary>
    /// <returns>The Pharma-Zentral-Nummer (Pzn) barcode symbology.</returns>
    public static extern uint Pzn { [MethodImpl] get; }

    /// <summary>Gets the Code 93 barcode symbology.</summary>
    /// <returns>The Code 93 barcode symbology.</returns>
    public static extern uint Code93 { [MethodImpl] get; }

    /// <summary>Gets the Code 93 Extended barcode symbology.</summary>
    /// <returns>The Code 93 Extended barcode symbology.</returns>
    public static extern uint Code93Ex { [MethodImpl] get; }

    /// <summary>Gets the Code 128 barcode symbology.</summary>
    /// <returns>The Code 128 barcode symbology.</returns>
    public static extern uint Code128 { [MethodImpl] get; }

    /// <summary>Gets the GS1 128 shipping container barcode symbology.</summary>
    /// <returns>The GS1 128 shipping container barcode symbology.</returns>
    public static extern uint Gs1128 { [MethodImpl] get; }

    /// <summary>Gets the GS1 128 Coupon barcode symbology.</summary>
    /// <returns>The GS1 128 Coupon barcode symbology.</returns>
    public static extern uint Gs1128Coupon { [MethodImpl] get; }

    /// <summary>Gets the UCC/EAN 128 barcode symbology.</summary>
    /// <returns>The UCC/EAN 128 barcode symbology.</returns>
    public static extern uint UccEan128 { [MethodImpl] get; }

    /// <summary>Gets the Serials Industry Systems Advisory Committee (SISAC) barcode symbology.</summary>
    /// <returns>The Serials Industry Systems Advisory Committee (SISAC) barcode symbology.</returns>
    public static extern uint Sisac { [MethodImpl] get; }

    /// <summary>Gets the International Society of Blood Transfusion (ISBT) 128 barcode symbology.</summary>
    /// <returns>The International Society of Blood Transfusion (ISBT) 128 barcode symbology.</returns>
    public static extern uint Isbt { [MethodImpl] get; }

    /// <summary>Gets the Codabar barcode symbology.</summary>
    /// <returns>The Codabar barcode symbology.</returns>
    public static extern uint Codabar { [MethodImpl] get; }

    /// <summary>Gets the Code 11 barcode symbology.</summary>
    /// <returns>The Code 11 barcode symbology.</returns>
    public static extern uint Code11 { [MethodImpl] get; }

    /// <summary>Gets the MSI barcode symbology.</summary>
    /// <returns>The MSI barcode symbology.</returns>
    public static extern uint Msi { [MethodImpl] get; }

    /// <summary>Gets the Plessey barcode symbology.</summary>
    /// <returns>The Plessey barcode symbology.</returns>
    public static extern uint Plessey { [MethodImpl] get; }

    /// <summary>Gets the Telepen barcode symbology.</summary>
    /// <returns>The Telepen barcode symbology.</returns>
    public static extern uint Telepen { [MethodImpl] get; }

    /// <summary>Gets the Code 16k barcode symbology.</summary>
    /// <returns>The Code 16k barcode symbology.</returns>
    public static extern uint Code16k { [MethodImpl] get; }

    /// <summary>Gets the Codablock A barcode symbology.</summary>
    /// <returns>The Codablock A barcode symbology.</returns>
    public static extern uint CodablockA { [MethodImpl] get; }

    /// <summary>Gets the Codablock F barcode symbology.</summary>
    /// <returns>The Codablock F barcode symbology.</returns>
    public static extern uint CodablockF { [MethodImpl] get; }

    /// <summary>Gets the Codablock 128 barcode symbology.</summary>
    /// <returns>The Codablock 128 barcode symbology.</returns>
    public static extern uint Codablock128 { [MethodImpl] get; }

    /// <summary>Gets the Code 49 barcode symbology.</summary>
    /// <returns>The Code 49 barcode symbology.</returns>
    public static extern uint Code49 { [MethodImpl] get; }

    /// <summary>Gets the Aztec barcode symbology.</summary>
    /// <returns>The Aztec barcode symbology.</returns>
    public static extern uint Aztec { [MethodImpl] get; }

    /// <summary>Gets the Data Code barcode symbology.</summary>
    /// <returns>The Data Code barcode symbology.</returns>
    public static extern uint DataCode { [MethodImpl] get; }

    /// <summary>Gets the Data Matric barcode symbology.</summary>
    /// <returns>The Data Matrix barcode symbology.</returns>
    public static extern uint DataMatrix { [MethodImpl] get; }

    /// <summary>Gets the Han Xin barcode symbology.</summary>
    /// <returns>The Han Xin barcode symbology.</returns>
    public static extern uint HanXin { [MethodImpl] get; }

    /// <summary>Gets the MaxiCode barcode symbology.</summary>
    /// <returns>The MaxiCode barcode symbology.</returns>
    public static extern uint Maxicode { [MethodImpl] get; }

    /// <summary>Gets the Micro PDF 417 barcode symbology.</summary>
    /// <returns>The Micro PDF 417 barcode symbology.</returns>
    public static extern uint MicroPdf417 { [MethodImpl] get; }

    /// <summary>Gets the Micro QR Code barcode symbology.</summary>
    /// <returns>The Micro QR Code barcode symbology.</returns>
    public static extern uint MicroQr { [MethodImpl] get; }

    /// <summary>Gets the PDF 417 barcode symbology.</summary>
    /// <returns>The PDF 417 barcode symbology.</returns>
    public static extern uint Pdf417 { [MethodImpl] get; }

    /// <summary>Gets the Quick Response (QR) Code barcode symbology.</summary>
    /// <returns>The Quick Response (QR) Code barcode symbology.</returns>
    public static extern uint Qr { [MethodImpl] get; }

    /// <summary>Gets the Microsoft tag barcode symbology.</summary>
    /// <returns>The Microsoft tag barcode symbology.</returns>
    public static extern uint MsTag { [MethodImpl] get; }

    /// <summary>Gets the Composite Component A or B barcode symbology.</summary>
    /// <returns>The Composite Component A or B barcode symbology.</returns>
    public static extern uint Ccab { [MethodImpl] get; }

    /// <summary>Gets the Composite Component-C barcode symbology.</summary>
    /// <returns>The Composite Component-C barcode symbology.</returns>
    public static extern uint Ccc { [MethodImpl] get; }

    /// <summary>Gets the TLC 39 barcode symbology.</summary>
    /// <returns>The TLC 39 barcode symbology.</returns>
    public static extern uint Tlc39 { [MethodImpl] get; }

    /// <summary>Gets the Australia Postal barcode symbology.</summary>
    /// <returns>The Australia Postal barcode symbology.</returns>
    public static extern uint AusPost { [MethodImpl] get; }

    /// <summary>Gets the Canada Postal barcode symbology.</summary>
    /// <returns>The Canada Postal barcode symbology.</returns>
    public static extern uint CanPost { [MethodImpl] get; }

    /// <summary>Gets the China Postal barcode symbology.</summary>
    /// <returns>The China Postal barcode symbology.</returns>
    public static extern uint ChinaPost { [MethodImpl] get; }

    /// <summary>Gets the Dutch Postal barcode symbology.</summary>
    /// <returns>The Dutch Postal barcode symbology.</returns>
    public static extern uint DutchKix { [MethodImpl] get; }

    /// <summary>Gets the InfoMail barcode symbology.</summary>
    /// <returns>The InfoMail barcode symbology.</returns>
    public static extern uint InfoMail { [MethodImpl] get; }

    /// <summary>Gets the Italian Post 25 barcode symbology.</summary>
    /// <returns>The Italian Post 25 barcode symbology.</returns>
    public static extern uint ItalianPost25 { [MethodImpl] get; }

    /// <summary>Gets the Italian Post 39 barcode symbology.</summary>
    /// <returns>The Italian Post 39 barcode symbology.</returns>
    public static extern uint ItalianPost39 { [MethodImpl] get; }

    /// <summary>Gets the Japan Postal barcode symbology.</summary>
    /// <returns>The Japan Postal barcode symbology.</returns>
    public static extern uint JapanPost { [MethodImpl] get; }

    /// <summary>Gets the Korea Postal barcode symbology.</summary>
    /// <returns>The Korea Postal barcode symbology.</returns>
    public static extern uint KoreanPost { [MethodImpl] get; }

    /// <summary>Gets the Sweden Postal barcode symbology.</summary>
    /// <returns>The Sweden Postal barcode symbology.</returns>
    public static extern uint SwedenPost { [MethodImpl] get; }

    /// <summary>Gets the UK Postal barcode symbology.</summary>
    /// <returns>The UK Postal barcode symbology.</returns>
    public static extern uint UkPost { [MethodImpl] get; }

    /// <summary>Gets the United States Postal Service (USPS) Intelligent Mail barcode symbology.</summary>
    /// <returns>The United States Postal Service (USPS) Intelligent Mail barcode symbology.</returns>
    public static extern uint UsIntelligent { [MethodImpl] get; }

    /// <summary>Gets the United States Postal Service (USPS) Intelligent Mail Package barcode symbology.</summary>
    /// <returns>The United States Postal Service (USPS) Intelligent Mail Package barcode symbology.</returns>
    public static extern uint UsIntelligentPkg { [MethodImpl] get; }

    /// <summary>Gets the United States Postal Service PLANET barcode symbology.</summary>
    /// <returns>The United States Postal Service PLANET barcode symbology.</returns>
    public static extern uint UsPlanet { [MethodImpl] get; }

    /// <summary>Gets the United States Postal Numeric Encoding Technique (POSTNET) barcode symbology.</summary>
    /// <returns>The United States Postal Numeric Encoding Technique (POSTNET) barcode symbology.</returns>
    public static extern uint UsPostNet { [MethodImpl] get; }

    /// <summary>Gets the United States Postal Service 4-State Flat Mail Identification Code Sort (FICS) barcode symbology.</summary>
    /// <returns>The United States Postal Service 4-State Flat Mail Identification Code Sort (FICS) barcode symbology.</returns>
    public static extern uint Us4StateFics { [MethodImpl] get; }

    /// <summary>Gets the OCR-A barcode symbology.</summary>
    /// <returns>The OCR-A barcode symbology.</returns>
    public static extern uint OcrA { [MethodImpl] get; }

    /// <summary>Gets the OCR-B barcode symbology.</summary>
    /// <returns>The OCR-B barcode symbology.</returns>
    public static extern uint OcrB { [MethodImpl] get; }

    /// <summary>Gets the Magnetic Ink Character Recognition (MICR) barcode symbology.</summary>
    /// <returns>The Magnetic Ink Character Recognition (MICR) barcode symbology.</returns>
    public static extern uint Micr { [MethodImpl] get; }

    /// <summary>Gets the first possible OEM defined barcode symbology when the symbology type is not included in the current list.</summary>
    /// <returns>The OEM defined barcode symbology.</returns>
    public static extern uint ExtendedBase { [MethodImpl] get; }

    /// <summary>Returns the barcode symbology type as a string.</summary>
    /// <param name="scanDataType">The barcode symbology type.</param>
    /// <returns>The barcode symbology type as a string.</returns>
    [MethodImpl]
    public static extern string GetName(uint scanDataType);
  }
}
