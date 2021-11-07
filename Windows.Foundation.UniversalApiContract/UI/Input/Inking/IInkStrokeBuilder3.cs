// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeBuilder3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2999394253, 21618, 18097, 168, 29, 195, 122, 61, 22, 148, 65)]
  [ExclusiveTo(typeof (InkStrokeBuilder))]
  internal interface IInkStrokeBuilder3
  {
    InkStroke CreateStrokeFromInkPoints(
      IIterable<InkPoint> inkPoints,
      Matrix3x2 transform,
      IReference<DateTime> strokeStartedTime,
      IReference<TimeSpan> strokeDuration);
  }
}
