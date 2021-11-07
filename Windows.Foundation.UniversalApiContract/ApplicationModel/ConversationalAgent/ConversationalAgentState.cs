// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ConversationalAgentState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies each possible AgentState for a digital assistant.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum ConversationalAgentState
  {
    /// <summary>The ConversationalAgent is not actively processing input or speaking to the user.</summary>
    Inactive,
    /// <summary>The ConversationalAgent is verifying the activation signal that activated it.</summary>
    Detecting,
    /// <summary>The ConversationalAgent is actively processing input.</summary>
    Listening,
    /// <summary>The ConversationalAgent is acting on the user's input and awaiting an outcome to continue the agent interaction.</summary>
    Working,
    /// <summary>The ConversationalAgent is actively speaking to the user.</summary>
    Speaking,
    /// <summary>The ConversationalAgent is concurrently processing input and speaking to the user.</summary>
    ListeningAndSpeaking,
  }
}
