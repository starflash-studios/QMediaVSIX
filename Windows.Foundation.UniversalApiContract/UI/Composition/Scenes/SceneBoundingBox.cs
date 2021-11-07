// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneBoundingBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a box that encloses a 3D scene.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [WebHostHidden]
  public sealed class SceneBoundingBox : SceneObject, ISceneBoundingBox
  {
    /// <summary>Gets the center of the bounding box.</summary>
    /// <returns>The center of the bounding box.</returns>
    public extern Vector3 Center { [MethodImpl] get; }

    /// <summary>Gets the extents of the bounding box.</summary>
    /// <returns>The extents of the bounding box.</returns>
    public extern Vector3 Extents { [MethodImpl] get; }

    /// <summary>Gets the maximum coordinates of the bounding box.</summary>
    /// <returns>The maximum coordinates of the bounding box.</returns>
    public extern Vector3 Max { [MethodImpl] get; }

    /// <summary>Gets the minimum coordinates of the bounding box.</summary>
    /// <returns>The minimum coordinates of the bounding box.</returns>
    public extern Vector3 Min { [MethodImpl] get; }

    /// <summary>Gets the size of the bounding box.</summary>
    /// <returns>The size of the bounding box.</returns>
    public extern Vector3 Size { [MethodImpl] get; }
  }
}
