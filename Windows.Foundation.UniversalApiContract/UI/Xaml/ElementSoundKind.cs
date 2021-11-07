// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementSoundKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that specify the sound played by the ElementSoundPlayer.Play method.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum ElementSoundKind
  {
    /// <summary>The sound to play when an element gets focus.</summary>
    Focus,
    /// <summary>The sound to play when an element is invoked.</summary>
    Invoke,
    /// <summary>The sound to play when a flyout, dialog, or command bar is opened.</summary>
    Show,
    /// <summary>The sound to play when a flyout, dialog, or command bar is closed.</summary>
    Hide,
    /// <summary>The sound to play when a user navigates to the previous panel or view within a page.</summary>
    MovePrevious,
    /// <summary>The sound to play when a user navigates to the next panel or view within a page.</summary>
    MoveNext,
    /// <summary>The sound to play when a user navigates back.</summary>
    GoBack,
  }
}
