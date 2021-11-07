// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwipeControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a container that provides access to contextual commands through touch interactions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (ISwipeControlStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (ISwipeControlFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class SwipeControl : ContentControl, ISwipeControl
  {
    /// <summary>Initializes a new instance of the SwipeControl class.</summary>
    [MethodImpl]
    public extern SwipeControl();

    /// <summary>Gets or sets the items that can be invoked when the control is swiped from the left side.</summary>
    /// <returns>The items that can be invoked when the control is swiped from the left side.</returns>
    public extern SwipeItems LeftItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the items that can be invoked when the control is swiped from the right side.</summary>
    /// <returns>The items that can be invoked when the control is swiped from the right side.</returns>
    public extern SwipeItems RightItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the items that can be invoked when the control is swiped from the top down.</summary>
    /// <returns>The items that can be invoked when the control is swiped from the top down.</returns>
    public extern SwipeItems TopItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the items that can be invoked when the control is swiped from the bottom up.</summary>
    /// <returns>The items that can be invoked when the control is swiped from the bottom up.</returns>
    public extern SwipeItems BottomItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Closes the swipe control.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Identifies the LeftItems dependency property.</summary>
    /// <returns>The identifier for the LeftItems dependency property.</returns>
    public static extern DependencyProperty LeftItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the RightItems dependency property.</summary>
    /// <returns>The identifier for the RightItems dependency property.</returns>
    public static extern DependencyProperty RightItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the TopItems dependency property.</summary>
    /// <returns>The identifier for the TopItems dependency property.</returns>
    public static extern DependencyProperty TopItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the BottomItems dependency property.</summary>
    /// <returns>The identifier for the BottomItems dependency property.</returns>
    public static extern DependencyProperty BottomItemsProperty { [MethodImpl] get; }
  }
}
