// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaBreakManager.BreakStarted event, which occurs when the playback of a MediaBreak starts.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaBreakStartedEventArgs : IMediaBreakStartedEventArgs
  {
    /// <summary>Gets the MediaBreak that triggered the MediaBreakManager.BreakStarted event.</summary>
    /// <returns>The MediaBreak that triggered the MediaBreakManager.BreakStarted event.</returns>
    public extern MediaBreak MediaBreak { [MethodImpl] get; }
  }
}
