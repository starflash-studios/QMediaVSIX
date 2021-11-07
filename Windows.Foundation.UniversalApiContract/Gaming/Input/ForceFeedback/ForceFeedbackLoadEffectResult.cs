// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ForceFeedbackLoadEffectResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>The results of an attempt to load a force feedback effect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum ForceFeedbackLoadEffectResult
  {
    /// <summary>The effect was successfully loaded.</summary>
    Succeeded,
    /// <summary>The effect was not loaded because storage is full.</summary>
    EffectStorageFull,
    /// <summary>The effect is not supported.</summary>
    EffectNotSupported,
  }
}
