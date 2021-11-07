// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewXYFocusTransferDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Specifies the direction of focus navigation relative to the input pane.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum CoreInputViewXYFocusTransferDirection
  {
    /// <summary>Focus movement is up.</summary>
    Up,
    /// <summary>Focus movement is to the right.</summary>
    Right,
    /// <summary>Focus movement is do</summary>
    Down,
    /// <summary>Focus movement is to the left.</summary>
    Left,
  }
}
