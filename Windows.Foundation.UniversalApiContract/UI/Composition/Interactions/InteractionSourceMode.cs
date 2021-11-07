// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionSourceMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Provides the various definitions for how a VisualInteractionSource will process interactions. Options available for the enumeration are </summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum InteractionSourceMode
  {
    /// <summary>Interaction is disabled.</summary>
    Disabled,
    /// <summary>Interaction is enabled with inertia.</summary>
    EnabledWithInertia,
    /// <summary>Interaction is enabled without inertia.</summary>
    EnabledWithoutInertia,
  }
}
