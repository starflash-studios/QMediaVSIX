// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IActivationSignalDetector2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ExclusiveTo(typeof (ActivationSignalDetector))]
  [Guid(3353495818, 47781, 22994, 133, 209, 186, 66, 247, 207, 120, 201)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IActivationSignalDetector2
  {
    [RemoteAsync]
    IAsyncOperation<IVector<string>> GetAvailableModelIdsForSignalIdAsync(
      string signalId);

    IVector<string> GetAvailableModelIdsForSignalId(string signalId);

    [RemoteAsync]
    IAsyncOperation<ActivationSignalDetectionConfigurationCreationResult> CreateConfigurationWithResultAsync(
      string signalId,
      string modelId,
      string displayName);

    ActivationSignalDetectionConfigurationCreationResult CreateConfigurationWithResult(
      string signalId,
      string modelId,
      string displayName);

    [RemoteAsync]
    IAsyncOperation<ActivationSignalDetectionConfigurationRemovalResult> RemoveConfigurationWithResultAsync(
      string signalId,
      string modelId);

    ActivationSignalDetectionConfigurationRemovalResult RemoveConfigurationWithResult(
      string signalId,
      string modelId);

    string DetectorId { get; }
  }
}
