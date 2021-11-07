// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.IXsltProcessorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(658589376, 39505, 18019, 191, 48, 14, 247, 66, 20, 111, 32)]
  [ExclusiveTo(typeof (XsltProcessor))]
  internal interface IXsltProcessorFactory
  {
    XsltProcessor CreateInstance(XmlDocument document);
  }
}
