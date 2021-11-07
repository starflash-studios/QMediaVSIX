// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SemanticZoom))]
  [Guid(2398191346, 39064, 18022, 178, 133, 62, 211, 138, 7, 145, 14)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISemanticZoomStatics
  {
    DependencyProperty ZoomedInViewProperty { get; }

    DependencyProperty ZoomedOutViewProperty { get; }

    DependencyProperty IsZoomedInViewActiveProperty { get; }

    DependencyProperty CanChangeViewsProperty { get; }

    DependencyProperty IsZoomOutButtonEnabledProperty { get; }
  }
}
