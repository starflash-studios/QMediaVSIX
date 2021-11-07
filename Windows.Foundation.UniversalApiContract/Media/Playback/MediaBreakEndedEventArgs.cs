// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakEndedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaBreakManager.BreakEnded event, which occurs when the playback of a MediaBreak has ended.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaBreakEndedEventArgs : IMediaBreakEndedEventArgs
  {
    /// <summary>Gets the MediaBreak for which playback has ended.</summary>
    /// <returns>The MediaBreak for which playback has ended.</returns>
    public extern MediaBreak MediaBreak { [MethodImpl] get; }
  }
}
