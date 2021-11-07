// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollViewerView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a view for a ScrollViewer when its view is changing.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ScrollViewerView : IScrollViewerView
  {
    /// <summary>Gets the distance the content has been scrolled horizontally.</summary>
    /// <returns>The distance the content has been scrolled horizontally.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the distance the content has been scrolled vertically.</summary>
    /// <returns>The distance the content has been scrolled vertically.</returns>
    public extern double VerticalOffset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the current zoom factor engaged for content scaling.</summary>
    /// <returns>The current zoom factor engaged for content scaling. The default is 1.0, where 1.0 indicates no additional scaling.</returns>
    public extern float ZoomFactor { [MethodImpl] get; }
  }
}
