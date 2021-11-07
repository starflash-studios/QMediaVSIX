// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Specifies the object that will fly between pages to provide context during a continuum transition.</summary>
  [Static(typeof (IContinuumNavigationTransitionInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class ContinuumNavigationTransitionInfo : 
    NavigationTransitionInfo,
    IContinuumNavigationTransitionInfo
  {
    /// <summary>Initializes a new instance of the ContinuumNavigationTransitionInfo class.</summary>
    [MethodImpl]
    public extern ContinuumNavigationTransitionInfo();

    /// <summary>Gets or sets the element that will fly between pages during a continuum navigation transition.</summary>
    /// <returns>The element that will fly between pages during a continuum navigation transition.</returns>
    public extern UIElement ExitElement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ExitElement dependency property.</summary>
    /// <returns>The identifier for the ExitElement dependency property.</returns>
    public static extern DependencyProperty ExitElementProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContinuumNavigationTransitionInfo.IsEntranceElement attached property.</summary>
    /// <returns>The identifier for the ContinuumNavigationTransitionInfo.IsEntranceElement attached property.</returns>
    public static extern DependencyProperty IsEntranceElementProperty { [MethodImpl] get; }

    /// <summary>Returns a Boolean value indicating if the specified **UIElement** is the entrance element for the continuum navigation.</summary>
    /// <param name="element">The **UIElement** to check as being the entrance element.</param>
    /// <returns>Returns **true** if *element* is the entrance element; otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsEntranceElement(UIElement element);

    /// <summary>Sets a Boolean value indicating if the specified **UIElement** is the entrance element for the continuum navigation.</summary>
    /// <param name="element">The **UIElement** about which to set the entrance element indicator.</param>
    /// <param name="value">Set this value to **true** if *element* is the entrance element; otherwise set it to **false**.</param>
    [MethodImpl]
    public static extern void SetIsEntranceElement(UIElement element, bool value);

    /// <summary>Identifies the ContinuumNavigationTransitionInfo.IsExitElement attached property.</summary>
    /// <returns>The identifier for the ContinuumNavigationTransitionInfo.IsExitElement attached property.</returns>
    public static extern DependencyProperty IsExitElementProperty { [MethodImpl] get; }

    /// <summary>Returns a Boolean value indicating if the specified **UIElement** is the exit element of the continuum navigation.</summary>
    /// <param name="element">The **UIElement** to check as being the exit element.</param>
    /// <returns>Returns **true** if *element* is the exit element; otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsExitElement(UIElement element);

    /// <summary>Sets a Boolean value indicating if the specified **UIElement** is the exit element for the continuum navigation.</summary>
    /// <param name="element">The **UIElement** about which to set the exit element indicator.</param>
    /// <param name="value">Set this value to **true** if *element* is the exit element; otherwise set it to **false**.</param>
    [MethodImpl]
    public static extern void SetIsExitElement(UIElement element, bool value);

    /// <summary>Identifies the ContinuumNavigationTransitionInfo.ExitElementContainer attached property.</summary>
    /// <returns>The identifier for the ContinuumNavigationTransitionInfo.ExitElementContainer attached property.</returns>
    public static extern DependencyProperty ExitElementContainerProperty { [MethodImpl] get; }

    /// <summary>Returns a Boolean value indicating if the specified element is the ExitElement container.</summary>
    /// <param name="element">The element to be checked as being the container.</param>
    /// <returns>Returns **true** if *element* is the container; otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool GetExitElementContainer(ListViewBase element);

    /// <summary>Sets a Boolean value indicating that the specified element is the exit element container for the continuum navigation.</summary>
    /// <param name="element">The element about which to set the exit element container indicator.</param>
    /// <param name="value">Set this value to **true** if *element* is the exit element; otherwise set it to **false**.</param>
    [MethodImpl]
    public static extern void SetExitElementContainer(ListViewBase element, bool value);
  }
}
