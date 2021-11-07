// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.Placement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Specifies where the context menu should be positioned relative to the selection rectangle.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Placement
  {
    /// <summary>Place the context menu above the selection rectangle.</summary>
    Default,
    /// <summary>Place the context menu above the selection rectangle.</summary>
    Above,
    /// <summary>Place the context menu below the selection rectangle.</summary>
    Below,
    /// <summary>Place the context menu to the left of the selection rectangle.</summary>
    Left,
    /// <summary>Place the context menu to the right of the selection rectangle.</summary>
    Right,
  }
}
