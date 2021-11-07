// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBorder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2038187321, 17853, 17971, 160, 68, 191, 176, 46, 245, 23, 15)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Border))]
  internal interface IBorder
  {
    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    Brush Background { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }

    UIElement Child { get; set; }

    TransitionCollection ChildTransitions { get; set; }
  }
}
