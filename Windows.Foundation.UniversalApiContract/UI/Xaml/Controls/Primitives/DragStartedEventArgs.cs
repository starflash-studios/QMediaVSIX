// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides data for the DragStarted event that occurs when a user drags a Thumb control with the mouse.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IDragStartedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class DragStartedEventArgs : RoutedEventArgs, IDragStartedEventArgs
  {
    /// <summary>Initializes a new instance of the DragStartedEventArgs class.</summary>
    /// <param name="horizontalOffset">The horizontal distance between the current mouse position and the thumb coordinates.</param>
    /// <param name="verticalOffset">The vertical distance between the current mouse position and the thumb coordinates.</param>
    [MethodImpl]
    public extern DragStartedEventArgs(double horizontalOffset, double verticalOffset);

    /// <summary>Gets the horizontal distance between the current mouse position and the thumb coordinates.</summary>
    /// <returns>The horizontal distance between the current mouse position and the thumb coordinates.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the vertical distance between the current mouse position and the thumb coordinates.</summary>
    /// <returns>The vertical distance between the current mouse position and the thumb coordinates.</returns>
    public extern double VerticalOffset { [MethodImpl] get; }
  }
}
