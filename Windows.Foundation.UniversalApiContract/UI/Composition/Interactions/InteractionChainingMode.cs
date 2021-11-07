// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionChainingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Defines the chaining behavior for a VisualInteractionSource. There are three options: Always chain, never chain or auto chain (let the system choose). If chaining is enabled, when an InteractionTracker reaches its minimum or maximum bounds, it will instead send the input to the next ancestor VisualInteractionSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum InteractionChainingMode
  {
    /// <summary>Automatically determine whether to continue the manipulation.</summary>
    Auto,
    /// <summary>Always continue the manipulation.</summary>
    Always,
    /// <summary>Never continue the manipulation.</summary>
    Never,
  }
}
