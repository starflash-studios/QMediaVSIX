// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNodeList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(2355146103, 33700, 20161, 156, 84, 123, 164, 41, 225, 61, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XmlNodeList))]
  internal interface IXmlNodeList : IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    uint Length { get; }

    IXmlNode Item(uint index);
  }
}
