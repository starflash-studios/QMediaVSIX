// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeRenderingSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStrokeRenderingSegment))]
  [Guid(1750142751, 35043, 18298, 162, 250, 86, 159, 95, 31, 155, 213)]
  internal interface IInkStrokeRenderingSegment
  {
    Point Position { get; }

    Point BezierControlPoint1 { get; }

    Point BezierControlPoint2 { get; }

    float Pressure { get; }

    float TiltX { get; }

    float TiltY { get; }

    float Twist { get; }
  }
}
