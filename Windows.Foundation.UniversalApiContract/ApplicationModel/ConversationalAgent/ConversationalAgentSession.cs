// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Audio;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>The communication channel between the digital assistant and the Windows Conversational Agent platform.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IConversationalAgentSessionStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConversationalAgentSession : 
    IConversationalAgentSession,
    IConversationalAgentSession2,
    IClosable
  {
    /// <summary>Occurs when another digital assistant activation signal has been detected.</summary>
    public extern event TypedEventHandler<ConversationalAgentSession, ConversationalAgentSessionInterruptedEventArgs> SessionInterrupted;

    /// <summary>Occurs when a Signal for activating a digital assistant is detected.</summary>
    public extern event TypedEventHandler<ConversationalAgentSession, ConversationalAgentSignalDetectedEventArgs> SignalDetected;

    /// <summary>Occurs when either the system or the user changes a setting that restricts the ability of the digital assistant to perform one or more actions.</summary>
    public extern event TypedEventHandler<ConversationalAgentSession, ConversationalAgentSystemStateChangedEventArgs> SystemStateChanged;

    /// <summary>Gets the state of the digital assistant.</summary>
    /// <returns>The state of the digital assistant.</returns>
    public extern ConversationalAgentState AgentState { [MethodImpl] get; }

    /// <summary>The Signal that activated the digital assistant, such as a keyword utterance, Bluetooth transmission, system keyboard accelerator, in-app speech recognition, or other sounds (door slam, smoke detector).</summary>
    /// <returns>The audible signal detected by the digital signal processor (DSP).</returns>
    public extern ConversationalAgentSignal Signal { [MethodImpl] get; }

    /// <summary>Gets whether the indicator light is available.</summary>
    /// <returns>True, if the indicator light is available; otherwise, false.</returns>
    public extern bool IsIndicatorLightAvailable { [MethodImpl] get; }

    /// <summary>Gets whether the screen can be turned on.</summary>
    /// <returns>True, if the screen can be turned on; otherwise, false.</returns>
    public extern bool IsScreenAvailable { [MethodImpl] get; }

    /// <summary>Gets whether the user is authenticated (for example, the device is locked).</summary>
    /// <returns>True, if user is authenticated; otherwise, false.</returns>
    public extern bool IsUserAuthenticated { [MethodImpl] get; }

    /// <summary>Gets whether the digital assistant can be activated by speech input.</summary>
    /// <returns>True, if speech input can activate the digital assistant; otherwise, false.</returns>
    public extern bool IsVoiceActivationAvailable { [MethodImpl] get; }

    /// <summary>Gets whether the ConversationalAgentSession can be interrupted.</summary>
    /// <returns>True, if the ConversationalAgentSession can be interrupted; otherwise, false.</returns>
    public extern bool IsInterruptible { [MethodImpl] get; }

    /// <summary>Gets whether the ConversationalAgentSession is being interrupted.</summary>
    /// <returns>True, if the ConversationalAgentSession is interrupted; otherwise, false.</returns>
    public extern bool IsInterrupted { [MethodImpl] get; }

    /// <summary>Asynchronously requests that this ConversationalAgentSession be interruptible if the keyword for another digital assistant is detected.</summary>
    /// <param name="interruptible">True, if interruptible; otherwise, false.</param>
    /// <returns>The result of the asynchronous operation as a ConversationalAgentSessionUpdateResponse.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConversationalAgentSessionUpdateResponse> RequestInterruptibleAsync(
      bool interruptible);

    /// <summary>Synchronously requests that this ConversationalAgentSession be interruptible if the keyword for another digital assistant is detected.</summary>
    /// <param name="interruptible">True, if interruptible; otherwise, false.</param>
    /// <returns>A ConversationalAgentSessionUpdateResponse.</returns>
    [MethodImpl]
    public extern ConversationalAgentSessionUpdateResponse RequestInterruptible(
      bool interruptible);

    /// <summary>Asynchronously requests a state change for the current ConversationalAgentSession.</summary>
    /// <param name="state">The AgentState requested.</param>
    /// <returns>The result of the asynchronous operation as a ConversationalAgentSessionUpdateResponse.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConversationalAgentSessionUpdateResponse> RequestAgentStateChangeAsync(
      ConversationalAgentState state);

    /// <summary>Synchronously requests a state change for the current ConversationalAgentSession.</summary>
    /// <param name="state">The AgentState requested.</param>
    /// <returns>A ConversationalAgentSessionUpdateResponse.</returns>
    [MethodImpl]
    public extern ConversationalAgentSessionUpdateResponse RequestAgentStateChange(
      ConversationalAgentState state);

    /// <summary>Asynchronously requests that the digital assistant be activated to the foreground.</summary>
    /// <returns>The result of the asynchronous operation as a ConversationalAgentSessionUpdateResponse.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConversationalAgentSessionUpdateResponse> RequestForegroundActivationAsync();

    /// <summary>Synchronously requests that the digital assistant be activated to the foreground.</summary>
    /// <returns>A ConversationalAgentSessionUpdateResponse.</returns>
    [MethodImpl]
    public extern ConversationalAgentSessionUpdateResponse RequestForegroundActivation();

    /// <summary>Asynchronously retrieves an IAudioClient object that creates and initializes an audio stream between your application and the audio rendering device.</summary>
    /// <returns>The result of the asynchronous operation as an IAudioClient object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<object> GetAudioClientAsync();

    /// <summary>Synchronously retrieves an IAudioClient object that creates and initializes an audio stream between your application and the audio rendering device.</summary>
    /// <returns>The IAudioClient object.</returns>
    [MethodImpl]
    public extern object GetAudioClient();

    /// <summary>Asynchronously creates an audio graph input node.</summary>
    /// <param name="graph">An audio graph that represents the connected input, output, and submix nodes for manipulating and routing audio.</param>
    /// <returns>The result of the asynchronous operation as an AudioDeviceInputNode.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AudioDeviceInputNode> CreateAudioDeviceInputNodeAsync(
      AudioGraph graph);

    /// <summary>Synchronously creates an audio graph input node.</summary>
    /// <param name="graph">An audio graph that represents the connected input, output, and submix nodes for manipulating and routing audio.</param>
    /// <returns>The AudioDeviceInputNode.</returns>
    [MethodImpl]
    public extern AudioDeviceInputNode CreateAudioDeviceInputNode(
      AudioGraph graph);

    /// <summary>Asynchronously retrieves the device ID for the current speech input device.</summary>
    /// <returns>The result of the asynchronous operation as a string.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetAudioCaptureDeviceIdAsync();

    /// <summary>Synchronously retrieves the device ID for the current speech input device.</summary>
    /// <returns>The ID as a string.</returns>
    [MethodImpl]
    public extern string GetAudioCaptureDeviceId();

    /// <summary>Asynchronously retrieves the device ID for the current speech output device.</summary>
    /// <returns>The result of the asynchronous operation as a string.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetAudioRenderDeviceIdAsync();

    /// <summary>Synchronously retrieves the device ID for the current speech output device.</summary>
    /// <returns>The ID as a string.</returns>
    [MethodImpl]
    public extern string GetAudioRenderDeviceId();

    /// <summary>Asynchronously retrieves the unique model identifier of the Signal that activated the conversational agent.</summary>
    /// <returns>When this method completes successfully, it returns a unique model identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetSignalModelIdAsync();

    /// <summary>Retrieves the unique model identifier of the Signal that activated the conversational agent.</summary>
    /// <returns>The unique model identifier.</returns>
    [MethodImpl]
    public extern uint GetSignalModelId();

    /// <summary>Asynchronously assigns a unique identifier to the model representing the activation audio signal for the conversational agent.</summary>
    /// <param name="signalModelId">The unique identifier.</param>
    /// <returns>An asynchronous operation with a value of **true** if the model identifier was set successfully; otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SetSignalModelIdAsync(uint signalModelId);

    /// <summary>Assigns a unique identifier to the model representing the activation audio signal for the conversational agent.</summary>
    /// <param name="signalModelId">The unique identifier.</param>
    /// <returns>True, if set successfully. Otherwise, false.</returns>
    [MethodImpl]
    public extern bool SetSignalModelId(uint signalModelId);

    /// <summary>Asynchronously retrieves the collection of unique Signal model identifiers supported by the conversational agent.</summary>
    /// <returns>When this method completes successfully, it returns a collection of unique Signal model identifiers.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<uint>> GetSupportedSignalModelIdsAsync();

    /// <summary>Retrieves the collection of unique Signal model identifiers supported by the conversational agent.</summary>
    /// <returns>A collection of unique Signal model identifiers.</returns>
    [MethodImpl]
    public extern IVectorView<uint> GetSupportedSignalModelIds();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConversationalAgentActivationResult> RequestActivationAsync(
      ConversationalAgentActivationKind activationKind);

    [MethodImpl]
    public extern ConversationalAgentActivationResult RequestActivation(
      ConversationalAgentActivationKind activationKind);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetSupportLockScreenActivationAsync(
      bool lockScreenActivationSupported);

    [MethodImpl]
    public extern void SetSupportLockScreenActivation(bool lockScreenActivationSupported);

    [MethodImpl]
    public extern IVectorView<ConversationalAgentVoiceActivationPrerequisiteKind> GetMissingPrerequisites();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ConversationalAgentVoiceActivationPrerequisiteKind>> GetMissingPrerequisitesAsync();

    [MethodImpl]
    public extern void Close();

    /// <summary>Asynchronously retrieves a reference to the current ConversationalAgentSession.</summary>
    /// <returns>The result of the asynchronous operation as a ConversationalAgentSession.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ConversationalAgentSession> GetCurrentSessionAsync();

    /// <summary>Synchronously retrieves a reference to the current ConversationalAgentSession.</summary>
    /// <returns>A reference to the current ConversationalAgentSession.</returns>
    [MethodImpl]
    public static extern ConversationalAgentSession GetCurrentSessionSync();
  }
}
