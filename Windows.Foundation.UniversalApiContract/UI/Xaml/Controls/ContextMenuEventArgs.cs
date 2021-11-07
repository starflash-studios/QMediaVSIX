// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContextMenuEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the **ContextMenuOpening** event that exists on several text-related UI elements.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContextMenuEventArgs : RoutedEventArgs, IContextMenuEventArgs
  {
    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**True** to mark the routed event handled. **False** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the pixel offset of the text cursor horizontal position.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double CursorLeft { [MethodImpl] get; }

    /// <summary>Gets the pixel offset of the text cursor vertical position.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double CursorTop { [MethodImpl] get; }
  }
}
