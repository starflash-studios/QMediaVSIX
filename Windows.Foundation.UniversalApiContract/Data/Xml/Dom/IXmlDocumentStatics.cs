// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1430508116, 55127, 19321, 149, 57, 35, 43, 24, 245, 11, 241)]
  [ExclusiveTo(typeof (XmlDocument))]
  internal interface IXmlDocumentStatics
  {
    [Overload("LoadFromUriAsync")]
    [RemoteAsync]
    IAsyncOperation<XmlDocument> LoadFromUriAsync(Uri uri);

    [RemoteAsync]
    [Overload("LoadFromUriWithSettingsAsync")]
    IAsyncOperation<XmlDocument> LoadFromUriAsync(
      Uri uri,
      XmlLoadSettings loadSettings);

    [RemoteAsync]
    [Overload("LoadFromFileAsync")]
    IAsyncOperation<XmlDocument> LoadFromFileAsync(IStorageFile file);

    [Overload("LoadFromFileWithSettingsAsync")]
    [RemoteAsync]
    IAsyncOperation<XmlDocument> LoadFromFileAsync(
      IStorageFile file,
      XmlLoadSettings loadSettings);
  }
}
