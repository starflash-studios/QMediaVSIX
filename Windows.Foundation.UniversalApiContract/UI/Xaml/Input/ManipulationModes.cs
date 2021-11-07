// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationModes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies how a target UI element interprets manipulation events. This enumeration is flagwise, so you can set multiple modes for the ManipulationMode property.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum ManipulationModes : uint
  {
    /// <summary>Do not present graphic interaction with manipulation events.</summary>
    None = 0,
    /// <summary>Permit manipulation actions that translate the target on the X axis.</summary>
    TranslateX = 1,
    /// <summary>Permit manipulation actions that translate the target on the Y axis.</summary>
    TranslateY = 2,
    /// <summary>Permit manipulation actions that translate the target on the X axis but using a rails mode.</summary>
    TranslateRailsX = 4,
    /// <summary>Permit manipulation actions that translate the target on the Y axis but using a rails mode.</summary>
    TranslateRailsY = 8,
    /// <summary>Permit manipulation actions that rotate the target.</summary>
    Rotate = 16, // 0x00000010
    /// <summary>Permit manipulation actions that scale the target.</summary>
    Scale = 32, // 0x00000020
    /// <summary>Apply inertia to translate actions.</summary>
    TranslateInertia = 64, // 0x00000040
    /// <summary>Apply inertia to rotate actions.</summary>
    RotateInertia = 128, // 0x00000080
    /// <summary>Apply inertia to scale actions.</summary>
    ScaleInertia = 256, // 0x00000100
    /// <summary>Enable all manipulation interaction modes except those supported through Direct Manipulation</summary>
    All = 65535, // 0x0000FFFF
    /// <summary>Enable system-driven touch interactions supported through Direct Manipulation.</summary>
    System = 65536, // 0x00010000
  }
}
