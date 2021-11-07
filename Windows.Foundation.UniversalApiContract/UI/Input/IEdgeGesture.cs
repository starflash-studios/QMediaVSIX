// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IEdgeGesture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1477268114, 10929, 18858, 167, 240, 51, 189, 63, 141, 249, 241)]
  [ExclusiveTo(typeof (EdgeGesture))]
  internal interface IEdgeGesture
  {
    event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting;

    event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed;

    event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled;
  }
}
