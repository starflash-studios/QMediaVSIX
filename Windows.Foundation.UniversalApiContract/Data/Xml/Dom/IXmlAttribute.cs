// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlAttribute))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2887010980, 46321, 19894, 178, 6, 138, 34, 195, 8, 219, 10)]
  internal interface IXmlAttribute : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Name { get; }

    bool Specified { get; }

    string Value { get; set; }
  }
}
