// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateKey
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2268818472, 52459, 19297, 134, 250, 178, 206, 195, 156, 194, 250)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DataTemplateKey))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTemplateKey
  {
    object DataType { get; set; }
  }
}
