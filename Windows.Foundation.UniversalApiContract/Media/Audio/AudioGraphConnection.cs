// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraphConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents a connection within an audio graph.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioGraphConnection : IAudioGraphConnection
  {
    /// <summary>Gets the destination node for the connection.</summary>
    /// <returns>The **IAudioNode** interface for the destination node.</returns>
    public extern IAudioNode Destination { [MethodImpl] get; }

    /// <summary>Gets the gain associated with the audio graph connection.</summary>
    /// <returns>A value indicating the gain.</returns>
    public extern double Gain { [MethodImpl] set; [MethodImpl] get; }
  }
}
