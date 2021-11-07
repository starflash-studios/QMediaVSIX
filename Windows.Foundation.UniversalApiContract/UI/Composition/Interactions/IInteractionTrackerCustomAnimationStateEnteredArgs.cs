// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerCustomAnimationStateEnteredArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Guid(2367458545, 55216, 17228, 165, 210, 45, 118, 17, 134, 72, 52)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InteractionTrackerCustomAnimationStateEnteredArgs))]
  internal interface IInteractionTrackerCustomAnimationStateEnteredArgs
  {
    int RequestId { get; }
  }
}
