// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshContainerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RefreshContainer))]
  [Guid(168064895, 2206, 16953, 186, 235, 196, 100, 20, 132, 195, 126)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IRefreshContainerFactory
  {
    RefreshContainer CreateInstance(object baseInterface, out object innerInterface);
  }
}
