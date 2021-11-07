// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ArcadeStickButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Specifies the button type for an arcade stick.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum ArcadeStickButtons : uint
  {
    /// <summary>No button.</summary>
    None = 0,
    /// <summary>The stick is pressed up.</summary>
    StickUp = 1,
    /// <summary>The stick is pressed down.</summary>
    StickDown = 2,
    /// <summary>The stick is pressed left.</summary>
    StickLeft = 4,
    /// <summary>The stick is pressed right.</summary>
    StickRight = 8,
    /// <summary>The first action button.</summary>
    Action1 = 16, // 0x00000010
    /// <summary>The second action button.</summary>
    Action2 = 32, // 0x00000020
    /// <summary>The third action button.</summary>
    Action3 = 64, // 0x00000040
    /// <summary>The fourth action button.</summary>
    Action4 = 128, // 0x00000080
    /// <summary>The fifth action button.</summary>
    Action5 = 256, // 0x00000100
    /// <summary>The sixth action button.</summary>
    Action6 = 512, // 0x00000200
    /// <summary>The first special button.</summary>
    Special1 = 1024, // 0x00000400
    /// <summary>The second special button.</summary>
    Special2 = 2048, // 0x00000800
  }
}
