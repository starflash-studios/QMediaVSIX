// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStroke2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkStroke))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1572463860, 47866, 19937, 137, 211, 32, 27, 30, 215, 216, 155)]
  internal interface IInkStroke2
  {
    Matrix3x2 PointTransform { get; set; }

    IVectorView<InkPoint> GetInkPoints();
  }
}
