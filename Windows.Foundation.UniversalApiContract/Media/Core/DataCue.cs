// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.DataCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Represents a data cue that can be included in a TimedMetadataTrack.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class DataCue : IDataCue, IMediaCue, IDataCue2
  {
    /// <summary>Initializes a new instance of the DataCue class.</summary>
    [MethodImpl]
    public extern DataCue();

    /// <summary>Gets the data associated with the cue.</summary>
    /// <returns>The data associated with the cue.</returns>
    public extern IBuffer Data { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the start time of the cue.</summary>
    /// <returns>The start time of the cue.</returns>
    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the cue.</summary>
    /// <returns>The duration of the cue.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the identifier for the data cue.</summary>
    /// <returns>The identifier for the data cue.</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the collection of custom properties associated with the data cue.</summary>
    /// <returns>The collection of custom properties associated with the data cue.</returns>
    public extern PropertySet Properties { [MethodImpl] get; }
  }
}
