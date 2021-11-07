// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioPlaybackConnectionOpenResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>The value returned from a call to Open or OpenAsync that indicates whether the call was successful and, if not, provides an extended error code.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class AudioPlaybackConnectionOpenResult : IAudioPlaybackConnectionOpenResult
  {
    /// <summary>Gets a value that indicates whether the call to call to Open or OpenAsync was successful.</summary>
    /// <returns>A member of the AudioPlaybackConnectionOpenResultStatus indicating whether the call was successful.</returns>
    public extern AudioPlaybackConnectionOpenResultStatus Status { [MethodImpl] get; }

    /// <summary>Gets the extended error code returned from a call to Open or OpenAsync.</summary>
    /// <returns>The extended error code.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
