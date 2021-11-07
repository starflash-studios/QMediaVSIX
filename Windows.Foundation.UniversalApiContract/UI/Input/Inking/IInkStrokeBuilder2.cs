// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeBuilder2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [Guid(3179461671, 29471, 19644, 187, 191, 109, 70, 128, 68, 241, 229)]
  [ExclusiveTo(typeof (InkStrokeBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkStrokeBuilder2
  {
    InkStroke CreateStrokeFromInkPoints(IIterable<InkPoint> inkPoints, Matrix3x2 transform);
  }
}
