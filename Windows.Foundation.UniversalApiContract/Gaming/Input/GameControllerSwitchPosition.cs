// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.GameControllerSwitchPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>The position of the game controller's switch.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GameControllerSwitchPosition
  {
    /// <summary>The center position.</summary>
    Center,
    /// <summary>The top position.</summary>
    Up,
    /// <summary>The top-right position.</summary>
    UpRight,
    /// <summary>The right position.</summary>
    Right,
    /// <summary>The bottom right position.</summary>
    DownRight,
    /// <summary>The bottom position.</summary>
    Down,
    /// <summary>The bottom left position.</summary>
    DownLeft,
    /// <summary>The left position.</summary>
    Left,
    /// <summary>The top-left position.</summary>
    UpLeft,
  }
}
