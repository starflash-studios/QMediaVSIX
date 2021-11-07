// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSystemStateChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies the possible state changes for the SystemStateChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum ConversationalAgentSystemStateChangeType
  {
    /// <summary>When set, indicates that the authentication status of the user has changed (such as when a user locks or unlocks a system). Corresponds to ConversationalAgentSession.IsUserAuthenticated.</summary>
    UserAuthentication,
    /// <summary>When set, indicates that the system's capability to turn on, or use, a display device has changed (this does not indicate whether or not the display is currently being used). Corresponds to ConversationalAgentSession.IsScreenAvailable.</summary>
    ScreenAvailability,
    /// <summary>When set, indicates that the system's capability to use status indicator lights has changed. </summary>
    IndicatorLightAvailability,
    /// <summary>When set, indicates voice activation availability has been changed through system settings or group policy. Corresponds to ConversationalAgentSession.IsVoiceActivationAvailable.</summary>
    VoiceActivationAvailability,
  }
}
