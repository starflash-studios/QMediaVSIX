// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IRectHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (RectHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1591829476, 49534, 18767, 181, 128, 47, 5, 116, 252, 58, 21)]
  internal interface IRectHelperStatics
  {
    Rect Empty { get; }

    Rect FromCoordinatesAndDimensions(float x, float y, float width, float height);

    Rect FromPoints(Point point1, Point point2);

    Rect FromLocationAndSize(Point location, Size size);

    bool GetIsEmpty(Rect target);

    float GetBottom(Rect target);

    float GetLeft(Rect target);

    float GetRight(Rect target);

    float GetTop(Rect target);

    bool Contains(Rect target, Point point);

    bool Equals(Rect target, Rect value);

    Rect Intersect(Rect target, Rect rect);

    [Overload("UnionWithPoint")]
    [DefaultOverload]
    Rect Union(Rect target, Point point);

    [Overload("UnionWithRect")]
    Rect Union(Rect target, Rect rect);
  }
}
