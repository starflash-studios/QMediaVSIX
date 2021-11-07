// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaStateEnteredArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InteractionTrackerInertiaStateEnteredArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2984981238, 49772, 16886, 161, 137, 250, 188, 34, 179, 35, 204)]
  internal interface IInteractionTrackerInertiaStateEnteredArgs2
  {
    bool IsInertiaFromImpulse { get; }
  }
}
