// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentDetectorManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [Guid(3734305712, 22906, 24056, 140, 251, 157, 187, 88, 59, 163, 255)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (ConversationalAgentDetectorManager))]
  internal interface IConversationalAgentDetectorManager
  {
    IVectorView<ActivationSignalDetector> GetAllActivationSignalDetectors();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ActivationSignalDetector>> GetAllActivationSignalDetectorsAsync();

    IVectorView<ActivationSignalDetector> GetActivationSignalDetectors(
      ActivationSignalDetectorKind kind);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ActivationSignalDetector>> GetActivationSignalDetectorsAsync(
      ActivationSignalDetectorKind kind);
  }
}
