// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSessionUpdateResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies each possible response for a ConversationalAgentSession update.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum ConversationalAgentSessionUpdateResponse
  {
    /// <summary>Indicates a ConversationalAgentSession update succeeded.</summary>
    Success,
    /// <summary>Indicates a ConversationalAgentSession update failed.</summary>
    Failed,
  }
}
