// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoom
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SemanticZoom))]
  [Guid(27262753, 60646, 20412, 191, 64, 137, 56, 212, 129, 62, 39)]
  [WebHostHidden]
  internal interface ISemanticZoom
  {
    ISemanticZoomInformation ZoomedInView { get; set; }

    ISemanticZoomInformation ZoomedOutView { get; set; }

    bool IsZoomedInViewActive { get; set; }

    bool CanChangeViews { get; set; }

    event SemanticZoomViewChangedEventHandler ViewChangeStarted;

    event SemanticZoomViewChangedEventHandler ViewChangeCompleted;

    void ToggleActiveView();

    bool IsZoomOutButtonEnabled { get; set; }
  }
}
