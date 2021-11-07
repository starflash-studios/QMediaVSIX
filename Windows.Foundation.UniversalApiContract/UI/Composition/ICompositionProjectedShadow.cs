// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionProjectedShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(677088882, 17192, 21055, 188, 242, 85, 87, 197, 44, 59, 37)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionProjectedShadow))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICompositionProjectedShadow
  {
    float BlurRadiusMultiplier { get; set; }

    CompositionProjectedShadowCasterCollection Casters { get; }

    CompositionLight LightSource { get; set; }

    float MaxBlurRadius { get; set; }

    float MinBlurRadius { get; set; }

    CompositionProjectedShadowReceiverUnorderedCollection Receivers { get; }
  }
}
