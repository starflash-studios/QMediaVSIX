// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Audio;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (ConversationalAgentSession))]
  [Guid(3668631706, 47034, 22501, 173, 19, 223, 82, 15, 155, 111, 167)]
  internal interface IConversationalAgentSession
  {
    event TypedEventHandler<ConversationalAgentSession, ConversationalAgentSessionInterruptedEventArgs> SessionInterrupted;

    event TypedEventHandler<ConversationalAgentSession, ConversationalAgentSignalDetectedEventArgs> SignalDetected;

    event TypedEventHandler<ConversationalAgentSession, ConversationalAgentSystemStateChangedEventArgs> SystemStateChanged;

    ConversationalAgentState AgentState { get; }

    ConversationalAgentSignal Signal { get; }

    bool IsIndicatorLightAvailable { get; }

    bool IsScreenAvailable { get; }

    bool IsUserAuthenticated { get; }

    bool IsVoiceActivationAvailable { get; }

    bool IsInterruptible { get; }

    bool IsInterrupted { get; }

    [RemoteAsync]
    IAsyncOperation<ConversationalAgentSessionUpdateResponse> RequestInterruptibleAsync(
      bool interruptible);

    ConversationalAgentSessionUpdateResponse RequestInterruptible(
      bool interruptible);

    [RemoteAsync]
    IAsyncOperation<ConversationalAgentSessionUpdateResponse> RequestAgentStateChangeAsync(
      ConversationalAgentState state);

    ConversationalAgentSessionUpdateResponse RequestAgentStateChange(
      ConversationalAgentState state);

    [RemoteAsync]
    IAsyncOperation<ConversationalAgentSessionUpdateResponse> RequestForegroundActivationAsync();

    ConversationalAgentSessionUpdateResponse RequestForegroundActivation();

    [RemoteAsync]
    IAsyncOperation<object> GetAudioClientAsync();

    object GetAudioClient();

    [RemoteAsync]
    IAsyncOperation<AudioDeviceInputNode> CreateAudioDeviceInputNodeAsync(
      AudioGraph graph);

    AudioDeviceInputNode CreateAudioDeviceInputNode(AudioGraph graph);

    [RemoteAsync]
    IAsyncOperation<string> GetAudioCaptureDeviceIdAsync();

    string GetAudioCaptureDeviceId();

    [RemoteAsync]
    IAsyncOperation<string> GetAudioRenderDeviceIdAsync();

    string GetAudioRenderDeviceId();

    [RemoteAsync]
    IAsyncOperation<uint> GetSignalModelIdAsync();

    uint GetSignalModelId();

    [RemoteAsync]
    IAsyncOperation<bool> SetSignalModelIdAsync(uint signalModelId);

    bool SetSignalModelId(uint signalModelId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<uint>> GetSupportedSignalModelIdsAsync();

    IVectorView<uint> GetSupportedSignalModelIds();
  }
}
