// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement10
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (UIElement))]
  [Guid(3576809001, 44332, 24427, 173, 207, 251, 135, 40, 125, 24, 215)]
  [WebHostHidden]
  internal interface IUIElement10
  {
    Vector3 ActualOffset { get; }

    Vector2 ActualSize { get; }

    XamlRoot XamlRoot { get; set; }

    UIContext UIContext { get; }

    Shadow Shadow { get; set; }
  }
}
