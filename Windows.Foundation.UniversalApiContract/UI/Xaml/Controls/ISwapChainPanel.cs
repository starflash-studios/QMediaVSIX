// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwapChainPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3314115663, 60328, 17018, 183, 90, 159, 31, 147, 161, 26, 233)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SwapChainPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISwapChainPanel
  {
    float CompositionScaleX { get; }

    float CompositionScaleY { get; }

    event TypedEventHandler<SwapChainPanel, object> CompositionScaleChanged;

    CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);
  }
}
