// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositorWithProjectedShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(2732995342, 35424, 23096, 187, 133, 180, 78, 169, 1, 103, 124)]
  [ExclusiveTo(typeof (Compositor))]
  internal interface ICompositorWithProjectedShadow
  {
    CompositionProjectedShadowCaster CreateProjectedShadowCaster();

    CompositionProjectedShadow CreateProjectedShadow();

    CompositionProjectedShadowReceiver CreateProjectedShadowReceiver();
  }
}
