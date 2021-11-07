// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionBindingAxisModes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Defines constants that specify which axis is bound between two interaction trackers.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Flags]
  public enum InteractionBindingAxisModes : uint
  {
    /// <summary>The binding does not affect any axis.</summary>
    None = 0,
    /// <summary>The binding affects the X axis.</summary>
    PositionX = 1,
    /// <summary>The binding affects the Y axis.</summary>
    PositionY = 2,
    /// <summary>The binding affects scale.</summary>
    Scale = 4,
  }
}
