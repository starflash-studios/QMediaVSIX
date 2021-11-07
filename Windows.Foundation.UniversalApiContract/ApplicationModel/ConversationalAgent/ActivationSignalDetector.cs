// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Represents hardware and software components that can generate activation signals based on input from a user's environment, such as spoken keyword(s), sound detection, or button press.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ActivationSignalDetector : 
    IActivationSignalDetector,
    IActivationSignalDetector2
  {
    /// <summary>Gets an identifier unique to the provider of this detector, such as the manufacturer of a hardware-based keyword spotter.</summary>
    /// <returns>The unique identifier of the provider.</returns>
    public extern string ProviderId { [MethodImpl] get; }

    /// <summary>Gets the supported ActivationSignalDetector types.</summary>
    /// <returns>The supported ActivationSignalDetector types.</returns>
    public extern ActivationSignalDetectorKind Kind { [MethodImpl] get; }

    /// <summary>Gets whether the ActivationSignalDetector can add or remove items from its collection of ActivationSignalDetectionConfiguration objects.</summary>
    /// <returns>True, if an ActivationSignalDetectionConfiguration object can be created. Otherwise, false.</returns>
    public extern bool CanCreateConfigurations { [MethodImpl] get; }

    /// <summary>Gets the model configuration data types supported by the signal detector.</summary>
    /// <returns>A collection of model configuration data types.</returns>
    public extern IVectorView<string> SupportedModelDataTypes { [MethodImpl] get; }

    /// <summary>Gets the supported formats for training an ActivationSignalDetector.</summary>
    /// <returns>An ActivationSignalDetectionConfiguration.TrainingDataFormat collection for training an ActivationSignalDetector.</returns>
    public extern IVectorView<ActivationSignalDetectionTrainingDataFormat> SupportedTrainingDataFormats { [MethodImpl] get; }

    /// <summary>Gets the power modes supported by an ActivationSignalDetector.</summary>
    /// <returns>A collection of ActivationSignalDetectorPowerState modes supported by an ActivationSignalDetector.</returns>
    public extern IVectorView<ActivationSignalDetectorPowerState> SupportedPowerStates { [MethodImpl] get; }

    /// <summary>Asynchronously gets the collection of model identifiers supported by this detector for the specified signal identifier. For example, all supported locales for language-specific versions of the "Hey Cortana" keyword.</summary>
    /// <param name="signalId">The locale-independent identifier for this configuration.</param>
    /// <returns>The collection of model identifiers supported through the specified signal.</returns>
    [MethodImpl]
    public extern IVectorView<string> GetSupportedModelIdsForSignalId(string signalId);

    /// <summary>Asynchronously gets the collection of model identifiers supported by this detector for the specified signal identifier. For example, all supported locales for language-specific versions of the "Hey Cortana" keyword.</summary>
    /// <param name="signalId">The locale-independent identifier for this configuration.</param>
    /// <returns>The collection of model identifiers supported through the specified signal.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetSupportedModelIdsForSignalIdAsync(
      string signalId);

    /// <summary>Creates an ActivationSignalDetectionConfiguration object associated with the specified ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair and adds it to the collection of supported configurations for the detector.</summary>
    /// <param name="signalId">The locale-independent identifier for this configuration.</param>
    /// <param name="modelId">The unique identifier, typically locale-specific, for the model data associated with this configuration.</param>
    /// <param name="displayName">The name of the signal in a localizable, human-readable form.</param>
    [MethodImpl]
    public extern void CreateConfiguration(string signalId, string modelId, string displayName);

    /// <summary>Asynchronously creates an ActivationSignalDetectionConfiguration object associated with the specified ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair and adds it to the collection of supported configurations for the detector.</summary>
    /// <param name="signalId">The locale-independent identifier for this configuration.</param>
    /// <param name="modelId">The unique identifier, typically locale-specific, for the model data associated with this configuration.</param>
    /// <param name="displayName">The name of the signal in a localizable, human-readable form.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CreateConfigurationAsync(
      string signalId,
      string modelId,
      string displayName);

    /// <summary>Gets the collection of ActivationSignalDetectionConfiguration objects associated with the ActivationSignalDetector.</summary>
    /// <returns>The collection of ActivationSignalDetectionConfiguration objects associated with the ActivationSignalDetector.</returns>
    [MethodImpl]
    public extern IVectorView<ActivationSignalDetectionConfiguration> GetConfigurations();

    /// <summary>Asynchronously gets the collection of ActivationSignalDetectionConfiguration objects associated with the ActivationSignalDetector.</summary>
    /// <returns>The collection of ActivationSignalDetectionConfiguration objects associated with the ActivationSignalDetector.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ActivationSignalDetectionConfiguration>> GetConfigurationsAsync();

    /// <summary>Gets the ActivationSignalDetectionConfiguration object associated with the specified ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair.</summary>
    /// <param name="signalId">The unique identifier for the ConversationalAgentSignal.</param>
    /// <param name="modelId">The unique model identifier of the Signal that activated the conversational agent.</param>
    /// <returns>The ActivationSignalDetectionConfiguration object associated with the specified ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair.</returns>
    [MethodImpl]
    public extern ActivationSignalDetectionConfiguration GetConfiguration(
      string signalId,
      string modelId);

    /// <summary>Asynchronously gets the ActivationSignalDetectionConfiguration object associated with the specified ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair.</summary>
    /// <param name="signalId">The unique identifier for the ConversationalAgentSignal.</param>
    /// <param name="modelId">The unique model identifier of the Signal that activated the conversational agent.</param>
    /// <returns>The ActivationSignalDetectionConfiguration object associated with the specified ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivationSignalDetectionConfiguration> GetConfigurationAsync(
      string signalId,
      string modelId);

    /// <summary>Removes the ActivationSignalDetectionConfiguration identified by the ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair.</summary>
    /// <param name="signalId">The unique identifier for the ConversationalAgentSignal.</param>
    /// <param name="modelId">The unique model identifier of the Signal that activated the conversational agent.</param>
    [MethodImpl]
    public extern void RemoveConfiguration(string signalId, string modelId);

    /// <summary>Asynchronously removes the ActivationSignalDetectionConfiguration identified by the ActivationSignalDetectionConfiguration.SignalId and ActivationSignalDetectionConfiguration.ModelId pair.</summary>
    /// <param name="signalId">The unique identifier for the ConversationalAgentSignal.</param>
    /// <param name="modelId">The unique model identifier of the Signal that activated the conversational agent.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveConfigurationAsync(string signalId, string modelId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<string>> GetAvailableModelIdsForSignalIdAsync(
      string signalId);

    [MethodImpl]
    public extern IVector<string> GetAvailableModelIdsForSignalId(string signalId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivationSignalDetectionConfigurationCreationResult> CreateConfigurationWithResultAsync(
      string signalId,
      string modelId,
      string displayName);

    [MethodImpl]
    public extern ActivationSignalDetectionConfigurationCreationResult CreateConfigurationWithResult(
      string signalId,
      string modelId,
      string displayName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivationSignalDetectionConfigurationRemovalResult> RemoveConfigurationWithResultAsync(
      string signalId,
      string modelId);

    [MethodImpl]
    public extern ActivationSignalDetectionConfigurationRemovalResult RemoveConfigurationWithResult(
      string signalId,
      string modelId);

    public extern string DetectorId { [MethodImpl] get; }
  }
}
