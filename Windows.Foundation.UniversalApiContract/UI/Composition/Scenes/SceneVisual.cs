// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a container visual for the nodes of a 3D scene.</summary>
  [Static(typeof (ISceneVisualStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 167772166)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SceneVisual : ContainerVisual, ISceneVisual
  {
    /// <summary>Gets or sets the root node for scene.</summary>
    /// <returns>The root node for scene.</returns>
    public extern SceneNode Root { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of SceneVisual.</summary>
    /// <param name="compositor">An instance of the Compositor class.</param>
    /// <returns>Returns the created SceneVisual object.</returns>
    [MethodImpl]
    public static extern SceneVisual Create(Compositor compositor);
  }
}
