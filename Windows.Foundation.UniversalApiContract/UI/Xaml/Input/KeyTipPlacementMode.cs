// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyTipPlacementMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Defines constants that specify where a Key Tip is placed in relation to a UIElement.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum KeyTipPlacementMode
  {
    /// <summary>The placement of the Key Tip is determined by the system.</summary>
    Auto,
    /// <summary>The Key Tip is placed below the element.</summary>
    Bottom,
    /// <summary>The Key Tip is placed above the element.</summary>
    Top,
    /// <summary>The Key Tip is placed left of the element.</summary>
    Left,
    /// <summary>The Key Tip is placed right of the element.</summary>
    Right,
    /// <summary>The Key Tip is centered on the element.</summary>
    Center,
    /// <summary>The Key Tip is not shown.</summary>
    Hidden,
  }
}
