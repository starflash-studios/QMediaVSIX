// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IPropertySetSerializer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(1854848796, 61245, 17270, 178, 14, 91, 230, 56, 174, 172, 119)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public interface IPropertySetSerializer
  {
    IBuffer Serialize(IPropertySet propertySet);

    void Deserialize(IPropertySet propertySet, IBuffer buffer);
  }
}
