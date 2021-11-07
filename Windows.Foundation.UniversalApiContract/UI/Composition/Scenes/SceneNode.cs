// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents an element in the scene's visual tree.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 167772166)]
  [Static(typeof (ISceneNodeStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class SceneNode : SceneObject, ISceneNode
  {
    /// <summary>Gets the collection of children of this node.</summary>
    /// <returns>The collection of children of this node.</returns>
    public extern SceneNodeCollection Children { [MethodImpl] get; }

    /// <summary>Gets the collection of components for this node.</summary>
    /// <returns>The collection of components for this node.</returns>
    public extern SceneComponentCollection Components { [MethodImpl] get; }

    /// <summary>Gets the node that this node is a child of.</summary>
    /// <returns>The node that this node is a child of.</returns>
    public extern SceneNode Parent { [MethodImpl] get; }

    /// <summary>Gets the transform that describes the position, rotation, and scale of this node.</summary>
    /// <returns>The transform that describes the position, rotation, and scale of this node.</returns>
    public extern SceneModelTransform Transform { [MethodImpl] get; }

    /// <summary>Retrieves the first component of the specified kind.</summary>
    /// <param name="value">The kind of component to find.</param>
    /// <returns>The first component of the specified kind, if one is found.</returns>
    [MethodImpl]
    public extern SceneComponent FindFirstComponentOfType(SceneComponentType value);

    /// <summary>Creates an instance of SceneNode.</summary>
    /// <param name="compositor">An instance of the Compositor class.</param>
    /// <returns>Returns the created SceneNode object.</returns>
    [MethodImpl]
    public static extern SceneNode Create(Compositor compositor);
  }
}
