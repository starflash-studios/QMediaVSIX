// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerCustomAnimationStateEnteredArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Arguments for the IInteractionTrackerOwner.CustomAnimationStateEntered callback.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  public sealed class InteractionTrackerCustomAnimationStateEnteredArgs : 
    IInteractionTrackerCustomAnimationStateEnteredArgs,
    IInteractionTrackerCustomAnimationStateEnteredArgs2
  {
    /// <summary>The ID of the request that triggered the callback.</summary>
    /// <returns>The ID of the request that triggered the callback.</returns>
    public extern int RequestId { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether this state was entered through interaction with a tracker that this one is bound to.</summary>
    /// <returns>**true** if this state was entered through interaction with a tracker that this one is bound to; **false** if the state was entered through interaction directly with this tracker.</returns>
    public extern bool IsFromBinding { [MethodImpl] get; }
  }
}
