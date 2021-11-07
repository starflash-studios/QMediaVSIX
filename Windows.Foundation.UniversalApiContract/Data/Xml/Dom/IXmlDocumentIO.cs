// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentIO
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1825630030, 61029, 17545, 158, 191, 202, 67, 232, 123, 166, 55)]
  [ExclusiveTo(typeof (XmlDocument))]
  internal interface IXmlDocumentIO
  {
    [Overload("LoadXml")]
    void LoadXml(string xml);

    [Overload("LoadXmlWithSettings")]
    void LoadXml(string xml, XmlLoadSettings loadSettings);

    [RemoteAsync]
    IAsyncAction SaveToFileAsync(IStorageFile file);
  }
}
