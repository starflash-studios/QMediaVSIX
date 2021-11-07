// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneAlphaMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Defines constants that specify the alpha mode for a scene.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum SceneAlphaMode
  {
    /// <summary>
    /// </summary>
    Opaque,
    /// <summary>
    /// </summary>
    AlphaTest,
    /// <summary>
    /// </summary>
    Blend,
  }
}
