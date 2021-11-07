// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainBackgroundPanelFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SwapChainBackgroundPanel))]
  [Guid(427985364, 51355, 18866, 137, 108, 89, 23, 191, 138, 220, 174)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISwapChainBackgroundPanelFactory
  {
    SwapChainBackgroundPanel CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
