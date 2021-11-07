// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementSoundPlayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a player for XAML control sounds.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Static(typeof (IElementSoundPlayerStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IElementSoundPlayerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class ElementSoundPlayer : IElementSoundPlayer
  {
    /// <summary>Gets or sets a value that indicates whether spatial audio is on, off, or handled automatically.</summary>
    /// <returns>An enumeration value that indicates whether spatial audio is on, off, or handled automatically. The default is **Auto**.</returns>
    public static extern ElementSpatialAudioMode SpatialAudioMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the volume of the sounds played by the Play method.</summary>
    /// <returns>The volume of the sounds played by the Play method. The default is 1.0.</returns>
    public static extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the system plays control sounds.</summary>
    /// <returns>A value of the enumeration that specifies whether the system plays control sounds. The default is **Auto**.</returns>
    public static extern ElementSoundPlayerState State { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Plays the specified sound.</summary>
    /// <param name="sound">A value of the enumeration that specifies the sound to play.</param>
    [MethodImpl]
    public static extern void Play(ElementSoundKind sound);
  }
}
