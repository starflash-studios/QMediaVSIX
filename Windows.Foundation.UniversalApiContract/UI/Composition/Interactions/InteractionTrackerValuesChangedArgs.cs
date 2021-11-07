// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerValuesChangedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Arguments for the IInteractionTrackerOwner.ValuesChanged callback.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  public sealed class InteractionTrackerValuesChangedArgs : IInteractionTrackerValuesChangedArgs
  {
    /// <summary>The current position of the InteractionTracker.</summary>
    /// <returns>The current position of the InteractionTracker.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>The ID of the request that triggered the callback.</summary>
    /// <returns>The ID of the request that triggered the callback.</returns>
    public extern int RequestId { [MethodImpl] get; }

    /// <summary>The current scale of the InteractionTracker.</summary>
    /// <returns>The current scale of the InteractionTracker.</returns>
    public extern float Scale { [MethodImpl] get; }
  }
}
