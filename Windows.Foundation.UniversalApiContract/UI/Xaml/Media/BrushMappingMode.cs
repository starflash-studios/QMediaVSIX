// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.BrushMappingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Specifies the coordinate system used by a Brush.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BrushMappingMode
  {
    /// <summary>The coordinate system is not relative to a bounding box. Values are interpreted directly in local space.</summary>
    Absolute,
    /// <summary>The coordinate system is relative to a bounding box: 0 indicates 0 percent of the bounding box, and 1 indicates 100 percent of the bounding box. For example, (0.5, 0.5) describes a point in the middle of the bounding box, and (1, 1) describes a point at the lower right of the bounding box.</summary>
    RelativeToBoundingBox,
  }
}
