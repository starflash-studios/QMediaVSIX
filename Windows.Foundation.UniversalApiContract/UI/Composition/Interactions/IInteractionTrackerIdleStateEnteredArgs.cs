// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerIdleStateEnteredArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1342255018, 5392, 16706, 161, 165, 1, 155, 9, 248, 133, 123)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InteractionTrackerIdleStateEnteredArgs))]
  internal interface IInteractionTrackerIdleStateEnteredArgs
  {
    int RequestId { get; }
  }
}
