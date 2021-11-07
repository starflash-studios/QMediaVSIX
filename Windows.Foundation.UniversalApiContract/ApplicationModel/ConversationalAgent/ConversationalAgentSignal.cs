// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSignal
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>A signal detected by an agent that corresponds to an ActivationSignalDetectionConfiguration. This signal indicates that the matching agent should be activated to handle an interaction.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConversationalAgentSignal : 
    IConversationalAgentSignal,
    IConversationalAgentSignal2
  {
    /// <summary>Gets or sets whether the ConversationalAgentSignal needs to be verified.</summary>
    /// <returns>True, if verification is required; otherwise, false.</returns>
    public extern bool IsSignalVerificationRequired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a unique identifier for the ConversationalAgentSignal.</summary>
    /// <returns>The signal identifier.</returns>
    public extern string SignalId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the ConversationalAgentSignal (for example, "Cortana" or "Alexa").</summary>
    /// <returns>The name of the signal.</returns>
    public extern string SignalName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the context for the ConversationalAgentSignal.</summary>
    /// <returns>The signal context.</returns>
    public extern object SignalContext { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time span of the ConversationalAgentSignal start.</summary>
    /// <returns>
    /// </returns>
    public extern TimeSpan SignalStart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time span of the ConversationalAgentSignal end.</summary>
    /// <returns>
    /// </returns>
    public extern TimeSpan SignalEnd { [MethodImpl] get; [MethodImpl] set; }

    public extern string DetectorId { [MethodImpl] get; }

    public extern ActivationSignalDetectorKind DetectorKind { [MethodImpl] get; }
  }
}
