// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocumentFragment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlDocumentFragment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3807013526, 3105, 17573, 139, 201, 158, 74, 38, 39, 8, 236)]
  internal interface IXmlDocumentFragment : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
  }
}
