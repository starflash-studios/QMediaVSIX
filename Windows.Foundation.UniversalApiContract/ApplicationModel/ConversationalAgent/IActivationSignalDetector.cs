// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IActivationSignalDetector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ExclusiveTo(typeof (ActivationSignalDetector))]
  [Guid(3049206879, 42192, 23339, 142, 101, 179, 197, 94, 231, 86, 255)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IActivationSignalDetector
  {
    string ProviderId { get; }

    ActivationSignalDetectorKind Kind { get; }

    bool CanCreateConfigurations { get; }

    IVectorView<string> SupportedModelDataTypes { get; }

    IVectorView<ActivationSignalDetectionTrainingDataFormat> SupportedTrainingDataFormats { get; }

    IVectorView<ActivationSignalDetectorPowerState> SupportedPowerStates { get; }

    IVectorView<string> GetSupportedModelIdsForSignalId(string signalId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetSupportedModelIdsForSignalIdAsync(
      string signalId);

    void CreateConfiguration(string signalId, string modelId, string displayName);

    [RemoteAsync]
    IAsyncAction CreateConfigurationAsync(
      string signalId,
      string modelId,
      string displayName);

    IVectorView<ActivationSignalDetectionConfiguration> GetConfigurations();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ActivationSignalDetectionConfiguration>> GetConfigurationsAsync();

    ActivationSignalDetectionConfiguration GetConfiguration(
      string signalId,
      string modelId);

    [RemoteAsync]
    IAsyncOperation<ActivationSignalDetectionConfiguration> GetConfigurationAsync(
      string signalId,
      string modelId);

    void RemoveConfiguration(string signalId, string modelId);

    [RemoteAsync]
    IAsyncAction RemoveConfigurationAsync(string signalId, string modelId);
  }
}
