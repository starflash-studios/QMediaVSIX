// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ConditionForceEffectKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>The type of the force feedback effect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum ConditionForceEffectKind
  {
    /// <summary>The force increases in proportion to the distance of the axis from a defined neutral point.</summary>
    Spring,
    /// <summary>The force increases in proportion to the velocity with which the user moves the axis.</summary>
    Damper,
    /// <summary>The force increases in proportion to the acceleration of the axis.</summary>
    Inertia,
    /// <summary>The force is applied when the axis is moved and depends on the defined friction coefficient.</summary>
    Friction,
  }
}
