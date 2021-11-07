// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentIO2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlDocument))]
  [Guid(1560495713, 31704, 19157, 158, 191, 129, 230, 52, 114, 99, 177)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlDocumentIO2
  {
    [Overload("LoadXmlFromBuffer")]
    void LoadXmlFromBuffer(IBuffer buffer);

    [Overload("LoadXmlFromBufferWithSettings")]
    void LoadXmlFromBuffer(IBuffer buffer, XmlLoadSettings loadSettings);
  }
}
