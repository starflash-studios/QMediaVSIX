// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementSoundPlayerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that specify whether XAML controls play sounds.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum ElementSoundPlayerState
  {
    /// <summary>The platform determines whether or not sounds are played.</summary>
    Auto,
    /// <summary>Sounds are never played on any platform.</summary>
    Off,
    /// <summary>Sounds are played on all platforms.</summary>
    On,
  }
}
