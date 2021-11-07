// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.EmbeddedAudioTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Editing
{
  /// <summary>Represents an audio track embedded in the media clip.</summary>
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class EmbeddedAudioTrack : IEmbeddedAudioTrack
  {
    /// <summary>Gets the AudioEncodingProperties for the embedded audio track.</summary>
    /// <returns>The AudioEncodingProperties for the embedded audio track.</returns>
    [MethodImpl]
    public extern AudioEncodingProperties GetAudioEncodingProperties();
  }
}
