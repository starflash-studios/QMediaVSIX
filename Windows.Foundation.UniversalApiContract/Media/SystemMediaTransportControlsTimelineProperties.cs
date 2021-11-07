// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsTimelineProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents timeline properties of the SystemMediaTransportControls. Pass an instance of this class to the UpdateTimelineProperties method to update the properties.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 167772160)]
  public sealed class SystemMediaTransportControlsTimelineProperties : 
    ISystemMediaTransportControlsTimelineProperties
  {
    /// <summary>Initializes a new instance of the SystemMediaTransportControlsTimelineProperties class.</summary>
    [MethodImpl]
    public extern SystemMediaTransportControlsTimelineProperties();

    /// <summary>Gets or sets a value representing the start time of the currently playing media item.</summary>
    /// <returns>A value representing the start time of the currently playing media item.</returns>
    public extern TimeSpan StartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value representing the end time of the currently playing media item.</summary>
    /// <returns>A value representing the end time of the currently playing media item</returns>
    public extern TimeSpan EndTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the earliest time within the currently playing media item to which the user can seek.</summary>
    /// <returns>A value indicating the earliest time within the currently playing media item to which the user can seek.</returns>
    public extern TimeSpan MinSeekTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the latest time within the currently playing media item to which the user can seek.</summary>
    /// <returns>The latest time within the currently playing media item to which the user can seek.</returns>
    public extern TimeSpan MaxSeekTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value representing the current playback position within the currently playing media item.</summary>
    /// <returns>The current playback position within the currently playing media item.</returns>
    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }
  }
}
