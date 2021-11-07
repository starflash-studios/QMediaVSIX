// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IWindowProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that provide fundamental window-based functionality within a traditional graphical user interface (GUI). Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(464161597, 14543, 16730, 133, 211, 32, 228, 58, 14, 193, 177)]
  public interface IWindowProvider
  {
    /// <summary>Gets a value that specifies whether the window is modal.</summary>
    /// <returns>**true** if the window is modal; otherwise, **false**.</returns>
    bool IsModal { get; }

    /// <summary>Gets a value that specifies whether the window is the topmost element in the z-order of layout.</summary>
    /// <returns>**true** if the window is topmost; otherwise, **false**.</returns>
    bool IsTopmost { get; }

    /// <summary>Gets a value that specifies whether the window can be maximized.</summary>
    /// <returns>**true** if the window can be maximized; otherwise, **false**.</returns>
    bool Maximizable { get; }

    /// <summary>Gets a value that specifies whether the window can be minimized.</summary>
    /// <returns>**true** if the window can be minimized; otherwise, **false**.</returns>
    bool Minimizable { get; }

    /// <summary>Gets the interaction state of the window.</summary>
    /// <returns>The interaction state of the control, as a value of the enumeration.</returns>
    WindowInteractionState InteractionState { get; }

    /// <summary>Gets the visual state of the window.</summary>
    /// <returns>The visual state of the window, as a value of the enumeration.</returns>
    WindowVisualState VisualState { get; }

    /// <summary>Closes the window.</summary>
    void Close();

    /// <summary>Changes the visual state of the window (such as minimizing or maximizing it).</summary>
    /// <param name="state">The visual state of the window to change to, as a value of the enumeration.</param>
    void SetVisualState(WindowVisualState state);

    /// <summary>Blocks the calling code for the specified time or until the associated process enters an idle state, whichever completes first.</summary>
    /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to become idle.</param>
    /// <returns>**true** if the window has entered the idle state; **false** if the timeout occurred.</returns>
    bool WaitForInputIdle(int milliseconds);
  }
}
