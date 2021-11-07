// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakSkippedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaBreakManager.BreakSkipped event, which occurs when the playback of a MediaBreak is skipped.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaBreakSkippedEventArgs : IMediaBreakSkippedEventArgs
  {
    /// <summary>Gets the MediaBreak that was skipped.</summary>
    /// <returns>The MediaBreak that was skipped.</returns>
    public extern MediaBreak MediaBreak { [MethodImpl] get; }
  }
}
