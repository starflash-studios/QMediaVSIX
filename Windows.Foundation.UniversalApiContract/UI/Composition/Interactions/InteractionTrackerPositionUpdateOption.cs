// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerPositionUpdateOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Defines constants that indicate whether an already running custom scale animation should be allowed to continue running.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [WebHostHidden]
  public enum InteractionTrackerPositionUpdateOption
  {
    /// <summary>An active scale animation will stop.</summary>
    Default,
    /// <summary>An active scale animation will continue.</summary>
    AllowActiveCustomScaleAnimation,
  }
}
