// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Provides the configuration details for a single signal supported by an activation signal detector. For example, the keyword "Hey Cortana" in US English.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ActivationSignalDetectionConfiguration : 
    IActivationSignalDetectionConfiguration,
    IClosable,
    IActivationSignalDetectionConfiguration2
  {
    /// <summary>Gets the locale-independent identifier for this configuration.</summary>
    /// <returns>The signal identifier.</returns>
    public extern string SignalId { [MethodImpl] get; }

    /// <summary>
    /// </summary>
    /// <returns>The unique model identifier.</returns>
    public extern string ModelId { [MethodImpl] get; }

    /// <summary>Gets the name of the signal in a localizable, human-readable form.</summary>
    /// <returns>The name of the signal.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets whether an ActivationSignalDetectionConfiguration object is processing configuration settings.</summary>
    /// <returns>True, if all criteria are met. Otherwise, false.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Enables or disables the configuration in an application-level manner, independent of system-level settings. The configuration must be both allowed and enabled for its associatedActivationSignalDetector.</summary>
    /// <param name="value">True, if enabled. Otherwise, false.</param>
    [MethodImpl]
    public extern void SetEnabled(bool value);

    /// <summary>Asynchronously enables or disables the configuration in an application-level manner, independent of system-level settings. The configuration must be both allowed and enabled for its associatedActivationSignalDetector.</summary>
    /// <param name="value">True, if enabled. Otherwise, false.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetEnabledAsync(bool value);

    /// <summary>Gets the current usage restrictions unique to this configuration.</summary>
    /// <returns>The availability state of the ActivationSignalDetector.</returns>
    public extern DetectionConfigurationAvailabilityInfo AvailabilityInfo { [MethodImpl] get; }

    /// <summary>Occurs when the availability state of the ActivationSignalDetector changes.</summary>
    public extern event TypedEventHandler<ActivationSignalDetectionConfiguration, DetectionConfigurationAvailabilityChangedEventArgs> AvailabilityChanged;

    /// <summary>Sets the model configuration data (specific to a signal detector).</summary>
    /// <param name="dataType">The type of configuration data that ensures compatibility with the detector.</param>
    /// <param name="data">The configuration data.</param>
    [MethodImpl]
    public extern void SetModelData(string dataType, IInputStream data);

    /// <summary>Asynchronously sets the model configuration data (specific to a signal detector).</summary>
    /// <param name="dataType">The type of configuration data that ensures compatibility with the detector.</param>
    /// <param name="data">The configuration data.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetModelDataAsync(string dataType, IInputStream data);

    /// <summary>Gets the model configuration data type (specific to a signal detector).</summary>
    /// <returns>The configuration data type, or null if no data exists.</returns>
    [MethodImpl]
    public extern string GetModelDataType();

    /// <summary>Asynchronously gets the model configuration data type (specific to a signal detector).</summary>
    /// <returns>The configuration data type, or null if no data exists.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetModelDataTypeAsync();

    /// <summary>Gets the model configuration data (specific to a signal detector).</summary>
    /// <returns>The configuration data, or null if no data exists.</returns>
    [MethodImpl]
    public extern IInputStream GetModelData();

    /// <summary>Asynchronously gets the model configuration data (specific to a signal detector).</summary>
    /// <returns>The configuration data, or null if no data exists.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IInputStream> GetModelDataAsync();

    /// <summary>Deletes all model data for the digital assistant.</summary>
    [MethodImpl]
    public extern void ClearModelData();

    /// <summary>Asynchronously deletes all model data for the digital assistant.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearModelDataAsync();

    /// <summary>Gets the number of steps completed in the training process of this configuration (if available).</summary>
    /// <returns>THe number of training steps completed.</returns>
    public extern uint TrainingStepsCompleted { [MethodImpl] get; }

    /// <summary>Gets the number of steps remaining in the training process of this configuration (if available).</summary>
    /// <returns>THe number of training steps remaining.</returns>
    public extern uint TrainingStepsRemaining { [MethodImpl] get; }

    /// <summary>Gets the supported data format used for signal detection training with this configuration (if available).</summary>
    /// <returns>The signal detection data format.</returns>
    public extern ActivationSignalDetectionTrainingDataFormat TrainingDataFormat { [MethodImpl] get; }

    /// <summary>Provides input data in the specified format and attempts to complete a training step (if a training process is available for the signal detector of this configuration).</summary>
    /// <param name="trainingDataFormat">The voice training data formats supported by the ActivationSignalDetector for the digital assistant.</param>
    /// <param name="trainingData">The voice training data.</param>
    /// <returns>The voice training data states recognized by the ActivationSignalDetector for the digital assistant.</returns>
    [MethodImpl]
    public extern DetectionConfigurationTrainingStatus ApplyTrainingData(
      ActivationSignalDetectionTrainingDataFormat trainingDataFormat,
      IInputStream trainingData);

    /// <summary>Asynchronously provides input data in the specified format and attempts to complete a training step (if a training process is available for the signal detector of this configuration).</summary>
    /// <param name="trainingDataFormat">The voice training data formats supported by the ActivationSignalDetector for the digital assistant.</param>
    /// <param name="trainingData">The voice training data.</param>
    /// <returns>The voice training data states recognized by the ActivationSignalDetector for the digital assistant.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DetectionConfigurationTrainingStatus> ApplyTrainingDataAsync(
      ActivationSignalDetectionTrainingDataFormat trainingDataFormat,
      IInputStream trainingData);

    /// <summary>Deletes all voice training data from the ActivationSignalDetector for the digital assistant.</summary>
    [MethodImpl]
    public extern void ClearTrainingData();

    /// <summary>Asynchronously deletes all voice training data from the ActivationSignalDetector for the digital assistant.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearTrainingDataAsync();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern ActivationSignalDetectionConfigurationSetModelDataResult SetModelDataWithResult(
      string dataType,
      IInputStream data);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivationSignalDetectionConfigurationSetModelDataResult> SetModelDataWithResultAsync(
      string dataType,
      IInputStream data);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivationSignalDetectionConfigurationStateChangeResult> SetEnabledWithResultAsync(
      bool value);

    [MethodImpl]
    public extern ActivationSignalDetectionConfigurationStateChangeResult SetEnabledWithResult(
      bool value);

    public extern uint TrainingStepCompletionMaxAllowedTime { [MethodImpl] get; }
  }
}
