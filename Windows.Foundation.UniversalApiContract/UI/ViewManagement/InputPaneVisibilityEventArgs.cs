// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.InputPaneVisibilityEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Provides data for the input pane Hiding and Showing events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class InputPaneVisibilityEventArgs : IInputPaneVisibilityEventArgs
  {
    /// <summary>Gets the region of the application's window that the input pane is covering.</summary>
    /// <returns>The window region that the input pane is covering, in client coordinates specified in device independent pixels (DIPs).</returns>
    public extern Rect OccludedRect { [MethodImpl] get; }

    /// <summary>Identifies whether the application has taken steps to ensure that the input pane doesn't cover the UI element that has focus.</summary>
    /// <returns>True if the application has ensured that the input pane isn't covering the UI element that has focus; otherwise false.</returns>
    public extern bool EnsuredFocusedElementInView { [MethodImpl] set; [MethodImpl] get; }
  }
}
