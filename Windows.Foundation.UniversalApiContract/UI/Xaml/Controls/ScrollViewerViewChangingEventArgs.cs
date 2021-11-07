// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the ViewChanging event and similar control-specific events.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ScrollViewerViewChangingEventArgs : IScrollViewerViewChangingEventArgs
  {
    /// <summary>Gets the view that the ScrollViewer will show next.</summary>
    /// <returns>The view that the ScrollViewer will show next.</returns>
    public extern ScrollViewerView NextView { [MethodImpl] get; }

    /// <summary>Gets the view that the ScrollViewer will show when the view comes to rest after a pan/zoom manipulation.</summary>
    /// <returns>The view that the ScrollViewer will show when the view comes to rest after a pan/zoom manipulation.</returns>
    public extern ScrollViewerView FinalView { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pan/zoom manipulation has an inertial component.</summary>
    /// <returns>**true** if the pan/zoom manipulation has an inertial component; otherwise, **false**.</returns>
    public extern bool IsInertial { [MethodImpl] get; }
  }
}
