// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentSession2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [Guid(2812935161, 44152, 22527, 149, 150, 172, 199, 161, 201, 166, 7)]
  [ExclusiveTo(typeof (ConversationalAgentSession))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IConversationalAgentSession2
  {
    [RemoteAsync]
    IAsyncOperation<ConversationalAgentActivationResult> RequestActivationAsync(
      ConversationalAgentActivationKind activationKind);

    ConversationalAgentActivationResult RequestActivation(
      ConversationalAgentActivationKind activationKind);

    [RemoteAsync]
    IAsyncAction SetSupportLockScreenActivationAsync(bool lockScreenActivationSupported);

    void SetSupportLockScreenActivation(bool lockScreenActivationSupported);

    IVectorView<ConversationalAgentVoiceActivationPrerequisiteKind> GetMissingPrerequisites();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ConversationalAgentVoiceActivationPrerequisiteKind>> GetMissingPrerequisitesAsync();
  }
}
