// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionProjectedShadowReceiver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(326604890, 27209, 21354, 155, 228, 169, 106, 142, 82, 152, 169)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (CompositionProjectedShadowReceiver))]
  internal interface ICompositionProjectedShadowReceiver
  {
    Visual ReceivingVisual { get; set; }
  }
}
