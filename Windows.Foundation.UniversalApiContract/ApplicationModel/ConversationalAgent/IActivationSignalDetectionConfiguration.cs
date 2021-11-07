// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IActivationSignalDetectionConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ExclusiveTo(typeof (ActivationSignalDetectionConfiguration))]
  [Guid(1087946262, 21015, 22556, 154, 178, 206, 155, 47, 46, 142, 0)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IActivationSignalDetectionConfiguration
  {
    string SignalId { get; }

    string ModelId { get; }

    string DisplayName { get; }

    bool IsActive { get; }

    void SetEnabled(bool value);

    [RemoteAsync]
    IAsyncAction SetEnabledAsync(bool value);

    DetectionConfigurationAvailabilityInfo AvailabilityInfo { get; }

    event TypedEventHandler<ActivationSignalDetectionConfiguration, DetectionConfigurationAvailabilityChangedEventArgs> AvailabilityChanged;

    void SetModelData(string dataType, IInputStream data);

    [RemoteAsync]
    IAsyncAction SetModelDataAsync(string dataType, IInputStream data);

    string GetModelDataType();

    [RemoteAsync]
    IAsyncOperation<string> GetModelDataTypeAsync();

    IInputStream GetModelData();

    [RemoteAsync]
    IAsyncOperation<IInputStream> GetModelDataAsync();

    void ClearModelData();

    [RemoteAsync]
    IAsyncAction ClearModelDataAsync();

    uint TrainingStepsCompleted { get; }

    uint TrainingStepsRemaining { get; }

    ActivationSignalDetectionTrainingDataFormat TrainingDataFormat { get; }

    DetectionConfigurationTrainingStatus ApplyTrainingData(
      ActivationSignalDetectionTrainingDataFormat trainingDataFormat,
      IInputStream trainingData);

    [RemoteAsync]
    IAsyncOperation<DetectionConfigurationTrainingStatus> ApplyTrainingDataAsync(
      ActivationSignalDetectionTrainingDataFormat trainingDataFormat,
      IInputStream trainingData);

    void ClearTrainingData();

    [RemoteAsync]
    IAsyncAction ClearTrainingDataAsync();
  }
}
