// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneSurfaceMaterialInputStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SceneSurfaceMaterialInput))]
  [Guid(1512281299, 25641, 17801, 187, 207, 184, 79, 79, 60, 251, 254)]
  internal interface ISceneSurfaceMaterialInputStatics
  {
    SceneSurfaceMaterialInput Create(Compositor compositor);
  }
}
