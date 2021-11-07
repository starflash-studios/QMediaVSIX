// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVoiceCommandResponseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceCommandResponse : IVoiceCommandResponse
  {
    /// <summary>The initial message that is spoken by **Cortana** and shown on the **Cortana** canvas.</summary>
    /// <returns>The message that is spoken or shown by **Cortana**.</returns>
    public extern VoiceCommandUserMessage Message { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The secondary message (for disambiguation and confirmation screens only) that is spoken by **Cortana** and shown on the **Cortana** canvas, if a response was not understood.</summary>
    /// <returns>The message that is spoken or shown by **Cortana**.</returns>
    public extern VoiceCommandUserMessage RepeatMessage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string as a launch parameter that can be associated with the response by the background app service.</summary>
    /// <returns>The string used as a launch parameter.</returns>
    public extern string AppLaunchArgument { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The collection of assets, containing image and text data, provided by the background app service for display on the **Cortana** canvas.</summary>
    /// <returns>The collection of assets.</returns>
    public extern IVector<VoiceCommandContentTile> VoiceCommandContentTiles { [MethodImpl] get; }

    /// <summary>Gets the maximum number of content tiles the background app service can display on the **Cortana** canvas.</summary>
    /// <returns>The maximum number of content tiles.</returns>
    public static extern uint MaxSupportedVoiceCommandContentTiles { [MethodImpl] get; }

    /// <summary>Creates a VoiceCommandResponse object used in calls to ReportProgressAsync, ReportSuccessAsync or ReportFailureAsync.</summary>
    /// <param name="userMessage">The message that is spoken by **Cortana** and shown on the **Cortana** canvas. </param>
    /// <returns>The response from the background app service for progress, completion, confirmation, or disambiguation screens displayed on the **Cortana** canvas.</returns>
    [Overload("CreateResponse")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponse(
      VoiceCommandUserMessage userMessage);

    [Overload("CreateResponseWithTiles")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponse(
      VoiceCommandUserMessage message,
      IIterable<VoiceCommandContentTile> contentTiles);

    /// <summary>Creates a VoiceCommandResponse object used in calls to RequestConfirmationAsync or RequestDisambiguationAsync.</summary>
    /// <param name="message">The initial message that is spoken by **Cortana** and shown on the **Cortana** canvas. </param>
    /// <param name="repeatMessage">The secondary message that is spoken by **Cortana** and shown on the **Cortana** canvas, if a response was not understood.</param>
    /// <returns>The response from the background app service for progress, completion, confirmation, or disambiguation screens displayed on the **Cortana** canvas.</returns>
    [Overload("CreateResponseForPrompt")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage);

    [Overload("CreateResponseForPromptWithTiles")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage,
      IIterable<VoiceCommandContentTile> contentTiles);
  }
}
