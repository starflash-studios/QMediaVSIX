// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (PointerPoint))]
  [Guid(2768659341, 10778, 16702, 188, 117, 159, 56, 56, 28, 192, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerPointStatics
  {
    [Overload("GetCurrentPoint")]
    PointerPoint GetCurrentPoint(uint pointerId);

    [Overload("GetIntermediatePoints")]
    IVector<PointerPoint> GetIntermediatePoints(uint pointerId);

    [Overload("GetCurrentPointTransformed")]
    PointerPoint GetCurrentPoint(uint pointerId, IPointerPointTransform transform);

    [Overload("GetIntermediatePointsTransformed")]
    IVector<PointerPoint> GetIntermediatePoints(
      uint pointerId,
      IPointerPointTransform transform);
  }
}
