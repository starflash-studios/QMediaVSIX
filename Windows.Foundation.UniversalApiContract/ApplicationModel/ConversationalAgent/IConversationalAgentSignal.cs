// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentSignal
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ExclusiveTo(typeof (ConversationalAgentSignal))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(552412663, 45344, 20978, 134, 3, 38, 93, 106, 71, 242, 50)]
  internal interface IConversationalAgentSignal
  {
    bool IsSignalVerificationRequired { get; set; }

    string SignalId { get; set; }

    string SignalName { get; set; }

    object SignalContext { get; set; }

    TimeSpan SignalStart { get; set; }

    TimeSpan SignalEnd { get; set; }
  }
}
