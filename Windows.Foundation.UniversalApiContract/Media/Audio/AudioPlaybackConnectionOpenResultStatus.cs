// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioPlaybackConnectionOpenResultStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies the result status of a call to  Open or OpenAsync</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum AudioPlaybackConnectionOpenResultStatus
  {
    /// <summary>The open request was successful.</summary>
    Success,
    /// <summary>The request timed out.</summary>
    RequestTimedOut,
    /// <summary>The open operation was denied by the system.</summary>
    DeniedBySystem,
    /// <summary>The request failed for an unknown reason. Check the ExtendedError property for more information.</summary>
    UnknownFailure,
  }
}
