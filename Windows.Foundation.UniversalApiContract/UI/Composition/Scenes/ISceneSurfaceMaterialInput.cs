// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneSurfaceMaterialInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [ExclusiveTo(typeof (SceneSurfaceMaterialInput))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(2570574428, 43466, 19708, 179, 170, 8, 131, 86, 81, 135, 66)]
  internal interface ISceneSurfaceMaterialInput
  {
    CompositionBitmapInterpolationMode BitmapInterpolationMode { get; set; }

    ICompositionSurface Surface { get; set; }

    SceneWrappingMode WrappingUMode { get; set; }

    SceneWrappingMode WrappingVMode { get; set; }
  }
}
