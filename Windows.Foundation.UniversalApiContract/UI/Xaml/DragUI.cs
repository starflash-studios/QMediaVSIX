// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragUI
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
  /// <summary>Provides the visual representation of the data being dragged at the start of a drag-and-drop operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class DragUI : IDragUI
  {
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

    /// <summary>Creates a system provided visual element that represents the format of the dragged data in a drag-and-drop operation, typically the icon of the default handler for the file format.</summary>
    [MethodImpl]
    public extern void SetContentFromDataPackage();
  }
}
