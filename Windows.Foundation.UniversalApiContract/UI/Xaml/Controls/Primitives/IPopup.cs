// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1648460352, 59091, 18181, 161, 220, 57, 21, 100, 86, 238, 41)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Popup))]
  internal interface IPopup
  {
    UIElement Child { get; set; }

    bool IsOpen { get; set; }

    double HorizontalOffset { get; set; }

    double VerticalOffset { get; set; }

    TransitionCollection ChildTransitions { get; set; }

    bool IsLightDismissEnabled { get; set; }

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;
  }
}
