// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInteractingStateEnteredArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(2804300089, 41339, 16401, 153, 253, 181, 194, 79, 20, 55, 72)]
  [ExclusiveTo(typeof (InteractionTrackerInteractingStateEnteredArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInteractionTrackerInteractingStateEnteredArgs
  {
    int RequestId { get; }
  }
}
