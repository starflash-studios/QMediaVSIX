// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragUIOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

namespace Windows.UI.Xaml
{
  /// <summary>Provides the visual representation of the data being dragged during a drag-and-drop operation, including feedback from the drop target.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DragUIOverride : IDragUIOverride
  {
    /// <summary>Gets or sets the caption text that overlays the drag visual. The text typically describes the drag-and-drop action.</summary>
    /// <returns>The caption text that overlays the drag visual.</returns>
    public extern string Caption { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the content of the drag visual is shown.</summary>
    /// <returns>**true** if the content is shown; otherwise, **false**.</returns>
    public extern bool IsContentVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the caption text is shown.</summary>
    /// <returns>**true** if the caption text is shown; otherwise, **false**.</returns>
    public extern bool IsCaptionVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the glyph is shown.</summary>
    /// <returns>**true** if the glyph is shown; otherwise, **false**.</returns>
    public extern bool IsGlyphVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Clears the content, caption, and glyph of the drag visual.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Creates a visual element from a provided BitmapImage to represent the dragged data in a drag-and-drop operation.</summary>
    /// <param name="bitmapImage">The source image used to create the drag visual.</param>
    [Overload("SetContentFromBitmapImage")]
    [MethodImpl]
    public extern void SetContentFromBitmapImage(BitmapImage bitmapImage);

    /// <summary>Creates a visual element from a provided BitmapImage to represent the dragged data in a drag-and-drop operation, and sets the relative position of the visual from the pointer.</summary>
    /// <param name="bitmapImage">The source image used to create the drag visual.</param>
    /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
    [Overload("SetContentFromBitmapImageWithAnchorPoint")]
    [MethodImpl]
    public extern void SetContentFromBitmapImage(BitmapImage bitmapImage, Point anchorPoint);

    /// <summary>Creates a visual element from a provided SoftwareBitmap to represent the dragged data in a drag-and-drop operation.</summary>
    /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
    [Overload("SetContentFromSoftwareBitmap")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    /// <summary>Creates a visual element from a provided SoftwareBitmap to represent the dragged data in a drag-and-drop operation, and sets the relative position of the visual from the pointer.</summary>
    /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
    /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(
      SoftwareBitmap softwareBitmap,
      Point anchorPoint);
  }
}
