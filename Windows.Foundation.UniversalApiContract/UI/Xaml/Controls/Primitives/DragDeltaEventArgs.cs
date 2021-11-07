// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides data for the DragDelta event that occurs one or more times when a user drags a Thumb control with the mouse.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IDragDeltaEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class DragDeltaEventArgs : RoutedEventArgs, IDragDeltaEventArgs
  {
    /// <summary>Initializes a new instance of the DragDeltaEventArgs class.</summary>
    /// <param name="horizontalChange">The horizontal change in the Thumb position since the last DragDelta event.</param>
    /// <param name="verticalChange">The vertical change in the Thumb position since the last DragDelta event.</param>
    [MethodImpl]
    public extern DragDeltaEventArgs(double horizontalChange, double verticalChange);

    /// <summary>Gets the horizontal change in the Thumb position since the last DragDelta event.</summary>
    /// <returns>The horizontal change in the Thumb position since the last DragDelta event.</returns>
    public extern double HorizontalChange { [MethodImpl] get; }

    /// <summary>Gets the vertical change in the Thumb position since the last DragDelta event.</summary>
    /// <returns>The vertical change in the Thumb position since the last DragDelta event.</returns>
    public extern double VerticalChange { [MethodImpl] get; }
  }
}
