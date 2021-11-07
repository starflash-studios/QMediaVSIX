// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IDtdEntity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (DtdEntity))]
  [Guid(1779130364, 25524, 18447, 158, 106, 138, 146, 129, 106, 173, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDtdEntity : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    object PublicId { [return: Variant] get; }

    object SystemId { [return: Variant] get; }

    object NotationName { [return: Variant] get; }
  }
}
