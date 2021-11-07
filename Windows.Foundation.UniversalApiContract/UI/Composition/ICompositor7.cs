// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.System;

namespace Windows.UI.Composition
{
  [Guid(3544727469, 39442, 21434, 191, 200, 136, 183, 255, 121, 119, 198)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (Compositor))]
  internal interface ICompositor7
  {
    DispatcherQueue DispatcherQueue { get; }

    AnimationPropertyInfo CreateAnimationPropertyInfo();

    [Overload("CreateRectangleClip")]
    RectangleClip CreateRectangleClip();

    [Overload("CreateRectangleClipWithSides")]
    RectangleClip CreateRectangleClip(
      float left,
      float top,
      float right,
      float bottom);

    [Overload("CreateRectangleClipWithSidesAndRadius")]
    RectangleClip CreateRectangleClip(
      float left,
      float top,
      float right,
      float bottom,
      Vector2 topLeftRadius,
      Vector2 topRightRadius,
      Vector2 bottomRightRadius,
      Vector2 bottomLeftRadius);
  }
}
