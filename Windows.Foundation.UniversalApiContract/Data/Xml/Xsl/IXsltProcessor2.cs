// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.IXsltProcessor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  [Guid(2376358998, 38821, 17611, 168, 190, 39, 216, 98, 128, 199, 10)]
  [ExclusiveTo(typeof (XsltProcessor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXsltProcessor2
  {
    XmlDocument TransformToDocument(IXmlNode inputNode);
  }
}
