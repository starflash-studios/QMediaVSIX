// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlComment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (XmlComment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3164894421, 46623, 17937, 156, 172, 46, 146, 227, 71, 109, 71)]
  internal interface IXmlComment : IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
  }
}
