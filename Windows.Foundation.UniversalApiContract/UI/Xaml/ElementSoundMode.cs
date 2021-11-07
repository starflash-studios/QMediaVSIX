// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementSoundMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that specify a control's preference for whether sounds are played.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum ElementSoundMode
  {
    /// <summary>Sound is played based on the ElementSoundPlayer.State setting.</summary>
    Default,
    /// <summary>Sound is played only when focus on the control changes.</summary>
    FocusOnly,
    /// <summary>No sounds are played.</summary>
    Off,
  }
}
