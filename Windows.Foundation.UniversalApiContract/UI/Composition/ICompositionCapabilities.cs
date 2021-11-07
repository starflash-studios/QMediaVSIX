// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(2186491198, 46359, 18620, 177, 232, 75, 53, 97, 162, 225, 129)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionCapabilities))]
  internal interface ICompositionCapabilities
  {
    bool AreEffectsSupported();

    bool AreEffectsFast();

    event TypedEventHandler<CompositionCapabilities, object> Changed;
  }
}
