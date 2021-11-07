// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides event data for the MarkerReached event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimelineMarkerRoutedEventArgs : RoutedEventArgs, ITimelineMarkerRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the TimelineMarkerRoutedEventArgs class.</summary>
    [MethodImpl]
    public extern TimelineMarkerRoutedEventArgs();

    /// <summary>Gets the TimelineMarker that triggered this event.</summary>
    /// <returns>The TimelineMarker that triggered this event.</returns>
    public extern TimelineMarker Marker { [MethodImpl] get; [MethodImpl] set; }
  }
}
