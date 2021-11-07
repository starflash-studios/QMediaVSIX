// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Diagnostics.CompositionDebugOverdrawContentKinds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Diagnostics
{
  /// <summary>Defines constants that specify what kinds of content are shown on an overdraw heatmap.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public enum CompositionDebugOverdrawContentKinds : uint
  {
    /// <summary>No content kinds are shown.</summary>
    None = 0,
    /// <summary>Elements rendered offscreen are shown.</summary>
    OffscreenRendered = 1,
    /// <summary>Colors are shown.</summary>
    Colors = 2,
    /// <summary>Effects are shown.</summary>
    Effects = 4,
    /// <summary>Shadows are shown.</summary>
    Shadows = 8,
    /// <summary>Lights are shown.</summary>
    Lights = 16, // 0x00000010
    /// <summary>Surfaces are shown.</summary>
    Surfaces = 32, // 0x00000020
    /// <summary>SwapChains are shown.</summary>
    SwapChains = 64, // 0x00000040
    /// <summary>All content kinds are shown.</summary>
    All = 4294967295, // 0xFFFFFFFF
  }
}
