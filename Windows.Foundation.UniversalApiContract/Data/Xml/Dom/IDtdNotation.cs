// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IDtdNotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(2360664141, 27974, 20187, 171, 115, 223, 131, 197, 26, 211, 151)]
  [ExclusiveTo(typeof (DtdNotation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDtdNotation : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    object PublicId { [return: Variant] get; }

    object SystemId { [return: Variant] get; }
  }
}
