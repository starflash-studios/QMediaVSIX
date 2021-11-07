// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.GameChatOverlayPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  /// <summary>Indicates the game chat overlay's position on the screen.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GameChatOverlayPosition
  {
    /// <summary>The bottom center position.</summary>
    BottomCenter,
    /// <summary>The bottom left position.</summary>
    BottomLeft,
    /// <summary>The bottom right position.</summary>
    BottomRight,
    /// <summary>The middle right position.</summary>
    MiddleRight,
    /// <summary>The middle left position.</summary>
    MiddleLeft,
    /// <summary>The top center position.</summary>
    TopCenter,
    /// <summary>The top left position.</summary>
    TopLeft,
    /// <summary>The top right position.</summary>
    TopRight,
  }
}
