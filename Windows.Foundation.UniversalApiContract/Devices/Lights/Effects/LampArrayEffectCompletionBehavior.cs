// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayEffectCompletionBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Behavior when an effect completes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum LampArrayEffectCompletionBehavior
  {
    /// <summary>Clears the state of all lamps when effect completes for the start of the next effect in the playlist. This is the typical case for most effects.</summary>
    ClearState,
    /// <summary>Maintains the state of all lamps when effect completes, so state is preserved for start of the next effect in the playlist. Use to seamlessly connect effects when the end state is known.</summary>
    KeepState,
  }
}
