// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ConversationalAgentTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task for processing digital assistant communication through the Windows platform Agent Activation Runtime (AAR).</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Activatable(524288, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  public sealed class ConversationalAgentTrigger : IBackgroundTrigger
  {
    /// <summary>Creates an instance of a ConversationalAgentTrigger.</summary>
    [MethodImpl]
    public extern ConversationalAgentTrigger();
  }
}
