// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerClampingOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Defines constants that specify how values are clamped when the InteractionTracker position is updated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  public enum InteractionTrackerClampingOption
  {
    /// <summary>If the input value is greater (or less) than the max (or min) value, it is immediately clamped.</summary>
    Auto,
    /// <summary>If the input value is greater (or less) than the max (or min) value, it is not immediately clamped. Instead, the max/min is enforced to the newly input value of Position (and potentially clamped) the next time InteractionTracker enters the Inertia state.</summary>
    Disabled,
  }
}
