// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomViewChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1205846120, 46441, 19225, 132, 45, 142, 108, 249, 9, 137, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SemanticZoomViewChangedEventArgs))]
  internal interface ISemanticZoomViewChangedEventArgs
  {
    bool IsSourceZoomedInView { get; set; }

    SemanticZoomLocation SourceItem { get; set; }

    SemanticZoomLocation DestinationItem { get; set; }
  }
}
