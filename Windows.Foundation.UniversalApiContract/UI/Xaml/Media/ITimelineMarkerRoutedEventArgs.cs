// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITimelineMarkerRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TimelineMarkerRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2084257523, 11400, 19868, 153, 182, 70, 205, 189, 72, 212, 193)]
  internal interface ITimelineMarkerRoutedEventArgs
  {
    TimelineMarker Marker { get; set; }
  }
}
