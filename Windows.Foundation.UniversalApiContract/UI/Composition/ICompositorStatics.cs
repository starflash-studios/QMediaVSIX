// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (Compositor))]
  [Guid(135117118, 4638, 19863, 139, 116, 29, 252, 249, 25, 135, 234)]
  [WebHostHidden]
  internal interface ICompositorStatics
  {
    float MaxGlobalPlaybackRate { get; }

    float MinGlobalPlaybackRate { get; }
  }
}
