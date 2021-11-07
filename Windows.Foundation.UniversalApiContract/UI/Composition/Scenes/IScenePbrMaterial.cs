// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.IScenePbrMaterial
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  [Guid(2864114622, 54912, 18143, 130, 148, 182, 128, 10, 159, 149, 231)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScenePbrMaterial))]
  internal interface IScenePbrMaterial
  {
    float AlphaCutoff { get; set; }

    SceneAlphaMode AlphaMode { get; set; }

    SceneMaterialInput EmissiveInput { get; set; }

    Vector3 EmissiveFactor { get; set; }

    bool IsDoubleSided { get; set; }

    SceneMaterialInput NormalInput { get; set; }

    float NormalScale { get; set; }

    SceneMaterialInput OcclusionInput { get; set; }

    float OcclusionStrength { get; set; }
  }
}
