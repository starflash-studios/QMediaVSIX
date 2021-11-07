// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlProcessingInstruction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlProcessingInstruction))]
  [Guid(654834974, 7826, 20174, 182, 244, 38, 240, 105, 7, 141, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlProcessingInstruction : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string Target { get; }

    string Data { get; set; }
  }
}
