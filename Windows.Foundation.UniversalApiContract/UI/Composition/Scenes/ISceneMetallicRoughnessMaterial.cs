﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneMetallicRoughnessMaterial
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  [ExclusiveTo(typeof (SceneMetallicRoughnessMaterial))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3252229190, 31132, 17054, 164, 228, 93, 166, 69, 241, 142, 97)]
  internal interface ISceneMetallicRoughnessMaterial
  {
    SceneMaterialInput BaseColorInput { get; set; }

    Vector4 BaseColorFactor { get; set; }

    float MetallicFactor { get; set; }

    SceneMaterialInput MetallicRoughnessInput { get; set; }

    float RoughnessFactor { get; set; }
  }
}