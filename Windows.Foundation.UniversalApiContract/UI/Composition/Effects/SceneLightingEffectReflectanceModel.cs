﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Effects.SceneLightingEffectReflectanceModel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Effects
{
  /// <summary>Defines constants that specify how the reflectance of a SceneLightingEffect is modeled.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public enum SceneLightingEffectReflectanceModel
  {
    /// <summary>The BlinnPhong model is used.</summary>
    BlinnPhong,
    /// <summary>The PhysicallyBasedBlinnPhong model is used.</summary>
    PhysicallyBasedBlinnPhong,
  }
}