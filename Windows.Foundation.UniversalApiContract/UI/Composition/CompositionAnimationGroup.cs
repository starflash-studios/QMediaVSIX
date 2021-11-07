// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionAnimationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Defines a group of animations.</summary>
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionAnimationGroup : 
    CompositionObject,
    ICompositionAnimationGroup,
    IIterable<CompositionAnimation>,
    ICompositionAnimationBase
  {
    /// <summary>The number of animations in the group.</summary>
    /// <returns>The number of animations in the group.</returns>
    public extern int Count { [MethodImpl] get; }

    /// <summary>Adds an animation to the animation group.</summary>
    /// <param name="value">The animation to add to the group.</param>
    [MethodImpl]
    public extern void Add(CompositionAnimation value);

    /// <summary>Removes an animation from the animation group.</summary>
    /// <param name="value">The animation to remove from the group.</param>
    [MethodImpl]
    public extern void Remove(CompositionAnimation value);

    /// <summary>Removes all animations from the group.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<CompositionAnimation> First();
  }
}
