// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XmlDocumentType))]
  [Guid(4147389477, 38785, 18788, 142, 148, 155, 28, 109, 252, 155, 199)]
  internal interface IXmlDocumentType : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Name { get; }

    XmlNamedNodeMap Entities { get; }

    XmlNamedNodeMap Notations { get; }
  }
}
