// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IActivationSignalDetectionConfiguration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [Guid(1910091810, 22060, 22478, 167, 139, 139, 79, 240, 20, 91, 171)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (ActivationSignalDetectionConfiguration))]
  internal interface IActivationSignalDetectionConfiguration2
  {
    ActivationSignalDetectionConfigurationSetModelDataResult SetModelDataWithResult(
      string dataType,
      IInputStream data);

    [RemoteAsync]
    IAsyncOperation<ActivationSignalDetectionConfigurationSetModelDataResult> SetModelDataWithResultAsync(
      string dataType,
      IInputStream data);

    [RemoteAsync]
    IAsyncOperation<ActivationSignalDetectionConfigurationStateChangeResult> SetEnabledWithResultAsync(
      bool value);

    ActivationSignalDetectionConfigurationStateChangeResult SetEnabledWithResult(
      bool value);

    uint TrainingStepCompletionMaxAllowedTime { get; }
  }
}
