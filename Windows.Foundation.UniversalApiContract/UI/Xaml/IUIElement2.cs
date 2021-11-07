// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1735199737, 46700, 16854, 186, 80, 88, 207, 135, 242, 1, 209)]
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElement))]
  internal interface IUIElement2
  {
    ElementCompositeMode CompositeMode { get; set; }

    bool CancelDirectManipulations();
  }
}
