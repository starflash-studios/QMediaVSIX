// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletionReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>Specifies the possible reasons the voice command completed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VoiceCommandCompletionReason
  {
    /// <summary>Unknown error.</summary>
    Unknown,
    /// <summary>Communication with **Cortana** failed.</summary>
    CommunicationFailed,
    /// <summary>The background app service exited because not enough resources were available.</summary>
    ResourceLimitsExceeded,
    /// <summary>The user cancelled the interaction with **Cortana**.</summary>
    Canceled,
    /// <summary>The background app service took too long to provide a response to **Cortana**.</summary>
    TimeoutExceeded,
    /// <summary>The background app service requested that the app launch in the foreground with a call to RequestAppLaunchAsync.</summary>
    AppLaunched,
    /// <summary>The background app service completed the interaction by calling ReportSuccessAsync or ReportFailureAsync.</summary>
    Completed,
  }
}
