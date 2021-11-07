// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify the preferred location for positioning a FlyoutBase derived control relative to a visual element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FlyoutPlacementMode
  {
    /// <summary>The preferred location of the flyout is above the target element.</summary>
    Top,
    /// <summary>The preferred location of the flyout is below the target element.</summary>
    Bottom,
    /// <summary>The preferred location of the flyout is to the left of the target element.</summary>
    Left,
    /// <summary>The preferred location of the flyout is to the right of the target element.</summary>
    Right,
    /// <summary>The preferred location of the flyout is centered on the screen.</summary>
    Full,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] TopEdgeAlignedLeft,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] TopEdgeAlignedRight,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] BottomEdgeAlignedLeft,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] BottomEdgeAlignedRight,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] LeftEdgeAlignedTop,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] LeftEdgeAlignedBottom,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] RightEdgeAlignedTop,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] RightEdgeAlignedBottom,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] Auto,
  }
}
