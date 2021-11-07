// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.GamepadButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Specifies the button type.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GamepadButtons : uint
  {
    /// <summary>No button.</summary>
    None = 0,
    /// <summary>Menu button.</summary>
    Menu = 1,
    /// <summary>View button.</summary>
    View = 2,
    /// <summary>A button.</summary>
    A = 4,
    /// <summary>B button.</summary>
    B = 8,
    /// <summary>X button.</summary>
    X = 16, // 0x00000010
    /// <summary>Y button.</summary>
    Y = 32, // 0x00000020
    /// <summary>D-pad up.</summary>
    DPadUp = 64, // 0x00000040
    /// <summary>D-pad down.</summary>
    DPadDown = 128, // 0x00000080
    /// <summary>D-pad left.</summary>
    DPadLeft = 256, // 0x00000100
    /// <summary>D-pad right.</summary>
    DPadRight = 512, // 0x00000200
    /// <summary>Left bumper.</summary>
    LeftShoulder = 1024, // 0x00000400
    /// <summary>Right bumper.</summary>
    RightShoulder = 2048, // 0x00000800
    /// <summary>Left stick.</summary>
    LeftThumbstick = 4096, // 0x00001000
    /// <summary>Right stick.</summary>
    RightThumbstick = 8192, // 0x00002000
    /// <summary>The first paddle.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle1 = 16384, // 0x00004000
    /// <summary>The second paddle.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle2 = 32768, // 0x00008000
    /// <summary>The third paddle.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle3 = 65536, // 0x00010000
    /// <summary>The fourth paddle.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Paddle4 = 131072, // 0x00020000
  }
}
