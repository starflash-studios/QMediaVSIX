// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IItemIndexRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2209887422, 1411, 18982, 155, 100, 139, 244, 162, 246, 87, 4)]
  [ExclusiveTo(typeof (ItemIndexRange))]
  internal interface IItemIndexRange
  {
    int FirstIndex { get; }

    uint Length { get; }

    int LastIndex { get; }
  }
}
