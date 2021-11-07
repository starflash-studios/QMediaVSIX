// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainPanelFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SwapChainPanel))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4086271359, 6728, 18891, 134, 210, 16, 234, 170, 246, 253, 112)]
  internal interface ISwapChainPanelFactory
  {
    SwapChainPanel CreateInstance(object baseInterface, out object innerInterface);
  }
}
