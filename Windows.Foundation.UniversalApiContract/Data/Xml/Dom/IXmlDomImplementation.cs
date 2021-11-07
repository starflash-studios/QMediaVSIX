// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDomImplementation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlDomImplementation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1843757362, 61725, 20411, 140, 198, 88, 60, 186, 147, 17, 47)]
  internal interface IXmlDomImplementation
  {
    bool HasFeature(string feature, [Variant] object version);
  }
}
