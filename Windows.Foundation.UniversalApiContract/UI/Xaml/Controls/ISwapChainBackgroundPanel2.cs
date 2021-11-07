// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainBackgroundPanel2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [Guid(568750834, 9618, 19512, 135, 15, 40, 251, 207, 82, 192, 149)]
  [ExclusiveTo(typeof (SwapChainBackgroundPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISwapChainBackgroundPanel2
  {
    CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);
  }
}
