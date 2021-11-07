// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>A collection of interaction sources.</summary>
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionInteractionSourceCollection : 
    CompositionObject,
    ICompositionInteractionSourceCollection,
    IIterable<ICompositionInteractionSource>
  {
    /// <summary>The number of interaction sources in the collection.</summary>
    /// <returns>The number of interaction sources in the collection.</returns>
    public extern int Count { [MethodImpl] get; }

    /// <summary>Adds an interaction source to the collection.</summary>
    /// <param name="value">The interaction source to add to the collection.</param>
    [MethodImpl]
    public extern void Add(ICompositionInteractionSource value);

    /// <summary>Removes the specified interaction source from the collection.</summary>
    /// <param name="value">The interaction source to remove from the collection.</param>
    [MethodImpl]
    public extern void Remove(ICompositionInteractionSource value);

    /// <summary>Removes all interaction sources from the collection.</summary>
    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<ICompositionInteractionSource> First();
  }
}
