// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionBitmapInterpolationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on screen.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum CompositionBitmapInterpolationMode
  {
    /// <summary>Use the exact color of the nearest bitmap pixel to the current rendering pixel.</summary>
    NearestNeighbor,
    /// <summary>Interpolate a color from the four bitmap pixels that are the nearest to the current rendering pixel.</summary>
    Linear,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagLinearMinLinearMipLinear,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagLinearMinLinearMipNearest,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagLinearMinNearestMipLinear,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagLinearMinNearestMipNearest,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagNearestMinLinearMipLinear,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagNearestMinLinearMipNearest,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagNearestMinNearestMipLinear,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] MagNearestMinNearestMipNearest,
  }
}
