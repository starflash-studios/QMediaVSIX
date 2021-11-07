// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ISceneBoundingBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  [Guid(1569717360, 50712, 16515, 130, 81, 153, 98, 89, 49, 20, 170)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SceneBoundingBox))]
  internal interface ISceneBoundingBox
  {
    Vector3 Center { get; }

    Vector3 Extents { get; }

    Vector3 Max { get; }

    Vector3 Min { get; }

    Vector3 Size { get; }
  }
}
