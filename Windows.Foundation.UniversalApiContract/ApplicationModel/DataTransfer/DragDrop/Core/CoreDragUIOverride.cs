// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragUIOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Contains methods and properties for customizing the drag and drop UI.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreDragUIOverride : ICoreDragUIOverride
  {
    /// <summary>Sets custom drag UI content using a software bitmap.</summary>
    /// <param name="softwareBitmap">The custom drag UI content.</param>
    [Overload("SetContentFromSoftwareBitmap")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    /// <summary>Sets custom drag UI content using a software bitmap.</summary>
    /// <param name="softwareBitmap">The custom UI drag content.</param>
    /// <param name="anchorPoint">The relative position of the drag visual from the pointer. The anchor point cannot be outside of the content. For example, if the anchor point is (50, 50) and the position of the pointer is (x, y), the top left corner for the visual will be (x - 50, y - 50).</param>
    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(
      SoftwareBitmap softwareBitmap,
      Point anchorPoint);

    /// <summary>Gets or sets whether the drag content is visible.</summary>
    /// <returns>True if the drag content is visible; otherwise, false.</returns>
    public extern bool IsContentVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the caption for the drag UI.</summary>
    /// <returns>The caption for the drag UI.</returns>
    public extern string Caption { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the caption for the drag UI is visible.</summary>
    /// <returns>True if the caption is visible; otherwise, false.</returns>
    public extern bool IsCaptionVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the glyph is visible.</summary>
    /// <returns>True if the glyph is visible; otherwise, false.</returns>
    public extern bool IsGlyphVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Clears all existing custom UI overrides.</summary>
    [MethodImpl]
    public extern void Clear();
  }
}
