// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppAttributeValue
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
  [Guid(2571141101, 58043, 22947, 152, 139, 40, 169, 116, 5, 42, 38)]
  internal interface IIppAttributeValue
  {
    IppAttributeValueKind Kind { get; }

    IVector<int> GetIntegerArray();

    IVector<bool> GetBooleanArray();

    IVector<int> GetEnumArray();

    IVector<IBuffer> GetOctetStringArray();

    IVector<DateTime> GetDateTimeArray();

    IVector<IppResolution> GetResolutionArray();

    IVector<IppIntegerRange> GetRangeOfIntegerArray();

    IVector<IMapView<string, IppAttributeValue>> GetCollectionArray();

    IVector<IppTextWithLanguage> GetTextWithLanguageArray();

    IVector<IppTextWithLanguage> GetNameWithLanguageArray();

    IVector<string> GetTextWithoutLanguageArray();

    IVector<string> GetNameWithoutLanguageArray();

    IVector<string> GetKeywordArray();

    IVector<Uri> GetUriArray();

    IVector<string> GetUriSchemaArray();

    IVector<string> GetCharsetArray();

    IVector<string> GetNaturalLanguageArray();

    IVector<string> GetMimeMediaTypeArray();
  }
}
