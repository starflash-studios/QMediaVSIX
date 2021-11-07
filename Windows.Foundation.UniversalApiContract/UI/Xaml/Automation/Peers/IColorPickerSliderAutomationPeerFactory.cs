// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IColorPickerSliderAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(441829246, 40406, 17827, 144, 66, 180, 2, 0, 254, 161, 169)]
  [ExclusiveTo(typeof (ColorPickerSliderAutomationPeer))]
  internal interface IColorPickerSliderAutomationPeerFactory
  {
    ColorPickerSliderAutomationPeer CreateInstanceWithOwner(
      ColorPickerSlider owner,
      object baseInterface,
      out object innerInterface);
  }
}
