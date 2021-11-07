// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides data for the DragCompleted event that occurs when a user completes a drag operation with the mouse of a Thumb control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IDragCompletedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DragCompletedEventArgs : RoutedEventArgs, IDragCompletedEventArgs
  {
    /// <summary>Initializes a new instance of the DragCompletedEventArgs class.</summary>
    /// <param name="horizontalChange">The horizontal change in position of the Thumb control, resulting from the drag operation.</param>
    /// <param name="verticalChange">The vertical change in position of the Thumb control, resulting from the drag operation.</param>
    /// <param name="canceled">A value that indicates whether the drag operation was canceled by a call to the CancelDrag method.</param>
    [MethodImpl]
    public extern DragCompletedEventArgs(
      double horizontalChange,
      double verticalChange,
      bool canceled);

    /// <summary>Gets the horizontal distance between the current mouse position and the thumb coordinates.</summary>
    /// <returns>The horizontal distance between the current mouse position and the thumb coordinates.</returns>
    public extern double HorizontalChange { [MethodImpl] get; }

    /// <summary>Gets the vertical distance between the current mouse position and the thumb coordinates.</summary>
    /// <returns>The vertical distance between the current mouse position and the thumb coordinates.</returns>
    public extern double VerticalChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the drag operation was canceled.</summary>
    /// <returns>**true** if the drag operation was canceled; otherwise, **false**.</returns>
    public extern bool Canceled { [MethodImpl] get; }
  }
}
