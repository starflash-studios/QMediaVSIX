// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlCDataSection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1292153967, 51389, 17844, 136, 153, 4, 0, 215, 194, 198, 15)]
  [ExclusiveTo(typeof (XmlCDataSection))]
  internal interface IXmlCDataSection : 
    IXmlText,
    IXmlCharacterData,
    IXmlNode,
    IXmlNodeSelector,
    IXmlNodeSerializer
  {
  }
}
