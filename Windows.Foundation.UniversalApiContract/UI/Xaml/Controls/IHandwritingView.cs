// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHandwritingView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (HandwritingView))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3292660903, 12768, 17596, 163, 139, 75, 238, 100, 236, 217, 159)]
  internal interface IHandwritingView
  {
    UIElement PlacementTarget { get; set; }

    HandwritingPanelPlacementAlignment PlacementAlignment { get; set; }

    bool IsOpen { get; }

    bool AreCandidatesEnabled { get; set; }

    event TypedEventHandler<HandwritingView, HandwritingPanelOpenedEventArgs> Opened;

    event TypedEventHandler<HandwritingView, HandwritingPanelClosedEventArgs> Closed;

    bool TryClose();

    bool TryOpen();
  }
}
