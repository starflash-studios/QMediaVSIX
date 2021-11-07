// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ForceFeedbackEffectAxes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>The axes the force feedback effect applies to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum ForceFeedbackEffectAxes : uint
  {
    /// <summary>The force feedback effect doesn't apply to any axes.</summary>
    None = 0,
    /// <summary>The force feedback effect applies to the x-axis.</summary>
    X = 1,
    /// <summary>The force feedback effect applies to the y-axis.</summary>
    Y = 2,
    /// <summary>The force feedback effect applies to the z-axis.</summary>
    Z = 4,
  }
}
