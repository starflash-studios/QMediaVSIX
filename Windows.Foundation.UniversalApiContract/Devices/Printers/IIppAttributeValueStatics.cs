// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppAttributeValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (IppAttributeValue))]
  [Guid(282343746, 56724, 22936, 178, 53, 175, 175, 182, 250, 121, 53)]
  internal interface IIppAttributeValueStatics
  {
    IppAttributeValue CreateUnsupported();

    IppAttributeValue CreateUnknown();

    IppAttributeValue CreateNoValue();

    IppAttributeValue CreateInteger(int value);

    IppAttributeValue CreateIntegerArray(IIterable<int> values);

    IppAttributeValue CreateBoolean(bool value);

    IppAttributeValue CreateBooleanArray(IIterable<bool> values);

    IppAttributeValue CreateEnum(int value);

    IppAttributeValue CreateEnumArray(IIterable<int> values);

    IppAttributeValue CreateOctetString(IBuffer value);

    IppAttributeValue CreateOctetStringArray(IIterable<IBuffer> values);

    IppAttributeValue CreateDateTime(DateTime value);

    IppAttributeValue CreateDateTimeArray(IIterable<DateTime> values);

    IppAttributeValue CreateResolution(IppResolution value);

    IppAttributeValue CreateResolutionArray(IIterable<IppResolution> values);

    IppAttributeValue CreateRangeOfInteger(IppIntegerRange value);

    IppAttributeValue CreateRangeOfIntegerArray(IIterable<IppIntegerRange> values);

    IppAttributeValue CreateCollection(
      IIterable<IKeyValuePair<string, IppAttributeValue>> memberAttributes);

    IppAttributeValue CreateCollectionArray(
      IIterable<IIterable<IKeyValuePair<string, IppAttributeValue>>> memberAttributesArray);

    IppAttributeValue CreateTextWithLanguage(IppTextWithLanguage value);

    IppAttributeValue CreateTextWithLanguageArray(
      IIterable<IppTextWithLanguage> values);

    IppAttributeValue CreateNameWithLanguage(IppTextWithLanguage value);

    IppAttributeValue CreateNameWithLanguageArray(
      IIterable<IppTextWithLanguage> values);

    IppAttributeValue CreateTextWithoutLanguage(string value);

    IppAttributeValue CreateTextWithoutLanguageArray(IIterable<string> values);

    IppAttributeValue CreateNameWithoutLanguage(string value);

    IppAttributeValue CreateNameWithoutLanguageArray(IIterable<string> values);

    IppAttributeValue CreateKeyword(string value);

    IppAttributeValue CreateKeywordArray(IIterable<string> values);

    IppAttributeValue CreateUri(Uri value);

    IppAttributeValue CreateUriArray(IIterable<Uri> values);

    IppAttributeValue CreateUriSchema(string value);

    IppAttributeValue CreateUriSchemaArray(IIterable<string> values);

    IppAttributeValue CreateCharset(string value);

    IppAttributeValue CreateCharsetArray(IIterable<string> values);

    IppAttributeValue CreateNaturalLanguage(string value);

    IppAttributeValue CreateNaturalLanguageArray(IIterable<string> values);

    IppAttributeValue CreateMimeMedia(string value);

    IppAttributeValue CreateMimeMediaArray(IIterable<string> values);
  }
}
