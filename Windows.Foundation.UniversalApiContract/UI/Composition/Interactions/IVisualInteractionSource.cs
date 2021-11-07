// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (VisualInteractionSource))]
  [Guid(3389950598, 55510, 16657, 176, 136, 112, 52, 123, 210, 176, 237)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVisualInteractionSource
  {
    bool IsPositionXRailsEnabled { get; set; }

    bool IsPositionYRailsEnabled { get; set; }

    VisualInteractionSourceRedirectionMode ManipulationRedirectionMode { get; set; }

    InteractionChainingMode PositionXChainingMode { get; set; }

    InteractionSourceMode PositionXSourceMode { get; set; }

    InteractionChainingMode PositionYChainingMode { get; set; }

    InteractionSourceMode PositionYSourceMode { get; set; }

    InteractionChainingMode ScaleChainingMode { get; set; }

    InteractionSourceMode ScaleSourceMode { get; set; }

    Visual Source { get; }

    void TryRedirectForManipulation(PointerPoint pointerPoint);
  }
}
