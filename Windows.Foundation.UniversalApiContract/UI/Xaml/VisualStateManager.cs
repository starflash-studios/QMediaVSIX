// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualStateManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  /// <summary>Manages visual states and the logic for transitions between visual states for controls. Also provides the attached property support for VisualStateManager.VisualStateGroups, which is how you define visual states in XAML for a control template.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IVisualStateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IVisualStateManagerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class VisualStateManager : 
    DependencyObject,
    IVisualStateManager,
    IVisualStateManagerProtected,
    IVisualStateManagerOverrides
  {
    /// <summary>Initializes a new instance of the VisualStateManager class.</summary>
    [MethodImpl]
    public extern VisualStateManager();

    [MethodImpl]
    extern void IVisualStateManagerProtected.RaiseCurrentStateChanging(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);

    [MethodImpl]
    extern void IVisualStateManagerProtected.RaiseCurrentStateChanged(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);

    [MethodImpl]
    extern bool IVisualStateManagerOverrides.GoToStateCore(
      Control control,
      FrameworkElement templateRoot,
      string stateName,
      VisualStateGroup group,
      VisualState state,
      bool useTransitions);

    /// <summary>Retrieves the collection of VisualStateGroup objects associated with the specified FrameworkElement.</summary>
    /// <param name="obj">The object to get the value from.</param>
    /// <returns>A collection of VisualStateGroup objects.</returns>
    [MethodImpl]
    public static extern IVector<VisualStateGroup> GetVisualStateGroups(
      FrameworkElement obj);

    /// <summary>Identifies the **VisualStateManager.CustomVisualStateManager** dependency property.</summary>
    /// <returns>The identifier for the **VisualStateManager.CustomVisualStateManager** dependency property.</returns>
    public static extern DependencyProperty CustomVisualStateManagerProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the VisualStateManager.CustomVisualStateManager attached property.</summary>
    /// <param name="obj">The object to get the value from.</param>
    /// <returns>The VisualStateManager that transitions between the states of a control.</returns>
    [MethodImpl]
    public static extern VisualStateManager GetCustomVisualStateManager(
      FrameworkElement obj);

    /// <summary>Sets the value of the VisualStateManager.CustomVisualStateManager attached property.</summary>
    /// <param name="obj">The target element where the property is set.</param>
    /// <param name="value">The VisualStateManager that transitions between the states of a control.</param>
    [MethodImpl]
    public static extern void SetCustomVisualStateManager(
      FrameworkElement obj,
      VisualStateManager value);

    /// <summary>Transitions a control between two states, by requesting a new VisualState by name.</summary>
    /// <param name="control">The control to transition between states.</param>
    /// <param name="stateName">The state to transition to.</param>
    /// <param name="useTransitions">**true** to use a VisualTransition to transition between states. **false** to skip using transitions and go directly to the requested state. The default is **false**.</param>
    /// <returns>**true** if the control successfully transitions to the new state, or was already using that state; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GoToState(Control control, string stateName, bool useTransitions);
  }
}
