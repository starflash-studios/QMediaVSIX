// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The background app service connection to **Cortana**.</summary>
  [Static(typeof (IVoiceCommandServiceConnectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceCommandServiceConnection : IVoiceCommandServiceConnection
  {
    /// <summary>Retrieves the voice command that the user submitted to **Cortana** by voice or text.</summary>
    /// <returns>The VoiceCommand.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoiceCommand> GetVoiceCommandAsync();

    /// <summary>Sends a response to **Cortana** indicating the voice command requires confirmation.</summary>
    /// <param name="response">The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</param>
    /// <returns>The VoiceCommandConfirmationResult object with the user's response.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoiceCommandConfirmationResult> RequestConfirmationAsync(
      VoiceCommandResponse response);

    /// <summary>Sends a response to **Cortana** indicating the voice command returned more than one result and requires the user to select one.</summary>
    /// <param name="response">The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</param>
    /// <returns>The VoiceCommandDisambiguationResult object with the user's response.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoiceCommandDisambiguationResult> RequestDisambiguationAsync(
      VoiceCommandResponse response);

    /// <summary>Sends a response to **Cortana** indicating voice command is being processed.</summary>
    /// <param name="response">The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportProgressAsync(VoiceCommandResponse response);

    /// <summary>Sends a response to **Cortana** indicating the voice command has succeeded.</summary>
    /// <param name="response">The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportSuccessAsync(VoiceCommandResponse response);

    /// <summary>Sends a response to **Cortana** indicating the voice command has failed.</summary>
    /// <param name="response">The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailureAsync(VoiceCommandResponse response);

    /// <summary>Sends a response to **Cortana** indicating the command should be handled by the app in the foreground.</summary>
    /// <param name="response">The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestAppLaunchAsync(VoiceCommandResponse response);

    /// <summary>Gets the locale for the voice command.</summary>
    /// <returns>The locale for the voice command.</returns>
    public extern Language Language { [MethodImpl] get; }

    /// <summary>Event raised when the voice command is completed and the background app service is about to be terminated.</summary>
    public extern event TypedEventHandler<VoiceCommandServiceConnection, VoiceCommandCompletedEventArgs> VoiceCommandCompleted;

    /// <summary>Retrieves a VoiceCommandServiceConnection object from the AppServiceTriggerDetails that contains info associated with the background task for the app service.</summary>
    /// <param name="triggerDetails">Contains info associated with the background task for the app service.</param>
    /// <returns>The background app service connection to **Cortana**.</returns>
    [MethodImpl]
    public static extern VoiceCommandServiceConnection FromAppServiceTriggerDetails(
      AppServiceTriggerDetails triggerDetails);
  }
}
