// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IItemIndexRangeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemIndexRange))]
  [Guid(2263008320, 11898, 19581, 166, 100, 232, 171, 240, 123, 252, 126)]
  [WebHostHidden]
  internal interface IItemIndexRangeFactory
  {
    ItemIndexRange CreateInstance(
      int firstIndex,
      uint length,
      object baseInterface,
      out object innerInterface);
  }
}
