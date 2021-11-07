// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraphUnrecoverableError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Defines unrecoverable errors for the audio graph.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioGraphUnrecoverableError
  {
    /// <summary>No unrecoverable errors were found.</summary>
    None,
    /// <summary>The audio device has been lost.</summary>
    AudioDeviceLost,
    /// <summary>The audio session has been disconnected.</summary>
    AudioSessionDisconnected,
    /// <summary>An unknown failure occurred during creation of the audio graph.</summary>
    UnknownFailure,
  }
}
