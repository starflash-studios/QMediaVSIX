// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentSystemStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ExclusiveTo(typeof (ConversationalAgentSystemStateChangedEventArgs))]
  [Guid(472673854, 10117, 22951, 142, 113, 56, 173, 238, 247, 153, 40)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IConversationalAgentSystemStateChangedEventArgs
  {
    ConversationalAgentSystemStateChangeType SystemStateChangeType { get; }
  }
}
