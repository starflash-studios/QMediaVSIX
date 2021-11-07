// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaMotionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2361933270, 47739, 17178, 132, 75, 110, 172, 145, 48, 249, 154)]
  [ExclusiveTo(typeof (InteractionTrackerInertiaMotion))]
  [WebHostHidden]
  internal interface IInteractionTrackerInertiaMotionStatics
  {
    InteractionTrackerInertiaMotion Create(Compositor compositor);
  }
}
