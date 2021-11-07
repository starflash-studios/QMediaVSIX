// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IRectangleClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RectangleClip))]
  [Guid(3018282142, 180, 23379, 139, 232, 53, 63, 108, 67, 49, 1)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IRectangleClip
  {
    float Bottom { get; set; }

    Vector2 BottomLeftRadius { get; set; }

    Vector2 BottomRightRadius { get; set; }

    float Left { get; set; }

    float Right { get; set; }

    float Top { get; set; }

    Vector2 TopLeftRadius { get; set; }

    Vector2 TopRightRadius { get; set; }
  }
}
