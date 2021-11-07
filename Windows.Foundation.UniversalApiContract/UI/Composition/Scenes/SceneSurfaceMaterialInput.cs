// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneSurfaceMaterialInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents an input to a composition surface.</summary>
  [DualApiPartition(version = 167772166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISceneSurfaceMaterialInputStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class SceneSurfaceMaterialInput : SceneMaterialInput, ISceneSurfaceMaterialInput
  {
    /// <summary>Gets or sets the bitmap interpolation mode.</summary>
    /// <returns>The bitmap interpolation mode.</returns>
    public extern CompositionBitmapInterpolationMode BitmapInterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the composition surface.</summary>
    /// <returns>The composition surface.</returns>
    public extern ICompositionSurface Surface { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how wrapping occurs on the U axis.</summary>
    /// <returns>A value that indicates how wrapping occurs on the U axis.</returns>
    public extern SceneWrappingMode WrappingUMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how wrapping occurs on the V axis.</summary>
    /// <returns>A value that indicates how wrapping occurs on the V axis.</returns>
    public extern SceneWrappingMode WrappingVMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of SceneSurfaceMaterialInput.</summary>
    /// <param name="compositor">An instance of the Compositor class.</param>
    /// <returns>Returns the created SceneSurfaceMaterialInput object.</returns>
    [MethodImpl]
    public static extern SceneSurfaceMaterialInput Create(
      Compositor compositor);
  }
}
