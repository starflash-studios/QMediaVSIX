// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IppAttributeValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Printers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Static(typeof (IIppAttributeValueStatics), 851968, "Windows.Foundation.UniversalApiContract")]
  public sealed class IppAttributeValue : IIppAttributeValue
  {
    public extern IppAttributeValueKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern IVector<int> GetIntegerArray();

    [MethodImpl]
    public extern IVector<bool> GetBooleanArray();

    [MethodImpl]
    public extern IVector<int> GetEnumArray();

    [MethodImpl]
    public extern IVector<IBuffer> GetOctetStringArray();

    [MethodImpl]
    public extern IVector<DateTime> GetDateTimeArray();

    [MethodImpl]
    public extern IVector<IppResolution> GetResolutionArray();

    [MethodImpl]
    public extern IVector<IppIntegerRange> GetRangeOfIntegerArray();

    [MethodImpl]
    public extern IVector<IMapView<string, IppAttributeValue>> GetCollectionArray();

    [MethodImpl]
    public extern IVector<IppTextWithLanguage> GetTextWithLanguageArray();

    [MethodImpl]
    public extern IVector<IppTextWithLanguage> GetNameWithLanguageArray();

    [MethodImpl]
    public extern IVector<string> GetTextWithoutLanguageArray();

    [MethodImpl]
    public extern IVector<string> GetNameWithoutLanguageArray();

    [MethodImpl]
    public extern IVector<string> GetKeywordArray();

    [MethodImpl]
    public extern IVector<Uri> GetUriArray();

    [MethodImpl]
    public extern IVector<string> GetUriSchemaArray();

    [MethodImpl]
    public extern IVector<string> GetCharsetArray();

    [MethodImpl]
    public extern IVector<string> GetNaturalLanguageArray();

    [MethodImpl]
    public extern IVector<string> GetMimeMediaTypeArray();

    [MethodImpl]
    public static extern IppAttributeValue CreateUnsupported();

    [MethodImpl]
    public static extern IppAttributeValue CreateUnknown();

    [MethodImpl]
    public static extern IppAttributeValue CreateNoValue();

    [MethodImpl]
    public static extern IppAttributeValue CreateInteger(int value);

    [MethodImpl]
    public static extern IppAttributeValue CreateIntegerArray(IIterable<int> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateBoolean(bool value);

    [MethodImpl]
    public static extern IppAttributeValue CreateBooleanArray(
      IIterable<bool> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateEnum(int value);

    [MethodImpl]
    public static extern IppAttributeValue CreateEnumArray(IIterable<int> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateOctetString(IBuffer value);

    [MethodImpl]
    public static extern IppAttributeValue CreateOctetStringArray(
      IIterable<IBuffer> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateDateTime(DateTime value);

    [MethodImpl]
    public static extern IppAttributeValue CreateDateTimeArray(
      IIterable<DateTime> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateResolution(IppResolution value);

    [MethodImpl]
    public static extern IppAttributeValue CreateResolutionArray(
      IIterable<IppResolution> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateRangeOfInteger(
      IppIntegerRange value);

    [MethodImpl]
    public static extern IppAttributeValue CreateRangeOfIntegerArray(
      IIterable<IppIntegerRange> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateCollection(
      IIterable<IKeyValuePair<string, IppAttributeValue>> memberAttributes);

    [MethodImpl]
    public static extern IppAttributeValue CreateCollectionArray(
      IIterable<IIterable<IKeyValuePair<string, IppAttributeValue>>> memberAttributesArray);

    [MethodImpl]
    public static extern IppAttributeValue CreateTextWithLanguage(
      IppTextWithLanguage value);

    [MethodImpl]
    public static extern IppAttributeValue CreateTextWithLanguageArray(
      IIterable<IppTextWithLanguage> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateNameWithLanguage(
      IppTextWithLanguage value);

    [MethodImpl]
    public static extern IppAttributeValue CreateNameWithLanguageArray(
      IIterable<IppTextWithLanguage> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateTextWithoutLanguage(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateTextWithoutLanguageArray(
      IIterable<string> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateNameWithoutLanguage(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateNameWithoutLanguageArray(
      IIterable<string> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateKeyword(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateKeywordArray(
      IIterable<string> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateUri(Uri value);

    [MethodImpl]
    public static extern IppAttributeValue CreateUriArray(IIterable<Uri> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateUriSchema(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateUriSchemaArray(
      IIterable<string> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateCharset(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateCharsetArray(
      IIterable<string> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateNaturalLanguage(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateNaturalLanguageArray(
      IIterable<string> values);

    [MethodImpl]
    public static extern IppAttributeValue CreateMimeMedia(string value);

    [MethodImpl]
    public static extern IppAttributeValue CreateMimeMediaArray(
      IIterable<string> values);
  }
}
