// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragUIOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [Guid(2309509220, 13193, 20303, 136, 151, 126, 138, 63, 251, 60, 147)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreDragUIOverride))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreDragUIOverride
  {
    [Overload("SetContentFromSoftwareBitmap")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint);

    bool IsContentVisible { get; set; }

    string Caption { get; set; }

    bool IsCaptionVisible { get; set; }

    bool IsGlyphVisible { get; set; }

    void Clear();
  }
}
