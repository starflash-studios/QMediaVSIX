// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.FlyoutShowMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify how a flyout behaves when shown.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum FlyoutShowMode
  {
    /// <summary>The show mode is determined automatically based on the method used to show the flyout.</summary>
    Auto,
    /// <summary>Behavior is typical of a flyout shown reactively, like a context menu. The open flyout takes focus. For a CommandBarFlyout, it opens in it's expanded state.</summary>
    Standard,
    /// <summary>Behavior is typical of a flyout shown proactively. The open flyout does not take focus. For a CommandBarFlyout, it opens in it's collapsed state.</summary>
    Transient,
    /// <summary>The flyout exhibits Transient behavior while the cursor is close to it, but is dismissed when the cursor moves away.</summary>
    TransientWithDismissOnPointerMoveAway,
  }
}
