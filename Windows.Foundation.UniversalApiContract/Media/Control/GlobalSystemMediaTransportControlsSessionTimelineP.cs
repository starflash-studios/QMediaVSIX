// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.GlobalSystemMediaTransportControlsSessionTimelineProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  /// <summary>Represents the timeline state of the session (Position, seek ranges etc.).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  public sealed class GlobalSystemMediaTransportControlsSessionTimelineProperties : 
    IGlobalSystemMediaTransportControlsSessionTimelineProperties
  {
    /// <summary>The starting timestamp of the current media item.</summary>
    /// <returns>A value representing the start time of the current media item.</returns>
    public extern TimeSpan StartTime { [MethodImpl] get; }

    /// <summary>The end timestamp of the current media item.</summary>
    /// <returns>A value representing the end time of the current media item.</returns>
    public extern TimeSpan EndTime { [MethodImpl] get; }

    /// <summary>The earliest timestamp at which the current media item can currently seek to.</summary>
    /// <returns>A value representing the min seek time of the current media item.</returns>
    public extern TimeSpan MinSeekTime { [MethodImpl] get; }

    /// <summary>The furthest timestamp at which the content can currently seek to.</summary>
    /// <returns>A value representing the max seek time of the current media item.</returns>
    public extern TimeSpan MaxSeekTime { [MethodImpl] get; }

    /// <summary>The playback position, current as of LastUpdatedTime.</summary>
    /// <returns>A value representing the playback position of the current media item.</returns>
    public extern TimeSpan Position { [MethodImpl] get; }

    /// <summary>The UTC time at which the timeline properties were last updated.</summary>
    /// <returns>A value representing the last time the timeline properties were updated.</returns>
    public extern DateTime LastUpdatedTime { [MethodImpl] get; }
  }
}
