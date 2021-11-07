// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.EffectiveViewportChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for the FrameworkElement.EffectiveViewportChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class EffectiveViewportChangedEventArgs : IEffectiveViewportChangedEventArgs
  {
    /// <summary>Gets the Rect representing the effective viewport.</summary>
    /// <returns>The Rect representing the effective viewport.</returns>
    public extern Rect EffectiveViewport { [MethodImpl] get; }

    /// <summary>Gets the Rect representing the maximum effective viewport with the current viewport sizes.</summary>
    /// <returns>The Rect representing the maximum effective viewport with the current viewport sizes.</returns>
    public extern Rect MaxViewport { [MethodImpl] get; }

    /// <summary>Gets the sum of translation in the X-axis that is required to bring the FrameworkElement into view of each viewport containing the element.</summary>
    /// <returns>The translation in the X-axis that is required to bring the FrameworkElement into view of each viewport containing the element</returns>
    public extern double BringIntoViewDistanceX { [MethodImpl] get; }

    /// <summary>Gets the sum of translation in the Y-axis that is required to bring the FrameworkElement into view of each viewport containing the element.</summary>
    /// <returns>The translation in the Y-axis that is required to bring the FrameworkElement into view of each viewport containing the element.</returns>
    public extern double BringIntoViewDistanceY { [MethodImpl] get; }
  }
}
