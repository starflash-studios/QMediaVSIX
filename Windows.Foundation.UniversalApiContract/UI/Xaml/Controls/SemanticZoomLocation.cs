// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoomLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Communicates information for items and view state in a SemanticZoom, such that hosts for scrolling and virtualization (such as ListViewBase ) can get correct item and bounds information.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SemanticZoomLocation : ISemanticZoomLocation
  {
    /// <summary>Initializes a new instance of the SemanticZoomLocation class.</summary>
    [MethodImpl]
    public extern SemanticZoomLocation();

    /// <summary>Gets or sets the display item as it exists in the current view of a SemanticZoom.</summary>
    /// <returns>The specific item in the SemanticZoom. </returns>
    public extern object Item { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the sizing bounds of the item as it exists in the current view of a SemanticZoom.</summary>
    /// <returns>The sizing bounds of the item. </returns>
    public extern Rect Bounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
