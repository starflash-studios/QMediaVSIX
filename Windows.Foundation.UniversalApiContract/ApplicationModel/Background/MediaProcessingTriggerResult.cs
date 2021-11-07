// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.MediaProcessingTriggerResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Specifies the result of a call to MediaProcessingTrigger.RequestAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaProcessingTriggerResult
  {
    /// <summary>The media processing trigger request was successful.</summary>
    Allowed,
    /// <summary>The media processing background task is currently running.</summary>
    CurrentlyRunning,
    /// <summary>The media processing trigger is disabled by policy on the device.</summary>
    DisabledByPolicy,
    /// <summary>An unknown error occurred.</summary>
    UnknownError,
  }
}
