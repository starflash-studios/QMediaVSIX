// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TimelineMarker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents metadata associated with a specific point in a media file.</summary>
  [Static(typeof (ITimelineMarkerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TimelineMarker : DependencyObject, ITimelineMarker
  {
    /// <summary>Initializes a new instance of the TimelineMarker class.</summary>
    [MethodImpl]
    public extern TimelineMarker();

    /// <summary>Gets or sets the time at which a TimelineMarker is reached.</summary>
    /// <returns>The time at which the TimelineMarker is reached. The default value is null.</returns>
    public extern TimeSpan Time { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the marker type of a TimelineMarker.</summary>
    /// <returns>A string that describes the type of this TimelineMarker. The default value is an empty string.</returns>
    public extern string Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text value of a TimelineMarker.</summary>
    /// <returns>The text value of the TimelineMarker. The default value is an empty string.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Time dependency property.</summary>
    /// <returns>The identifier for the Time dependency property.</returns>
    public static extern DependencyProperty TimeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Type dependency property.</summary>
    /// <returns>The identifier for the Type dependency property.</returns>
    public static extern DependencyProperty TypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Text dependency property.</summary>
    /// <returns>The identifier for the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }
  }
}
