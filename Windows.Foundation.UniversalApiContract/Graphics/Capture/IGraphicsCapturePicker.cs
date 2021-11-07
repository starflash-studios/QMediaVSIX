// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCapturePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  [WebHostHidden]
  [Guid(1511461299, 44409, 19274, 147, 54, 19, 24, 253, 222, 53, 57)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (GraphicsCapturePicker))]
  internal interface IGraphicsCapturePicker
  {
    [RemoteAsync]
    IAsyncOperation<GraphicsCaptureItem> PickSingleItemAsync();
  }
}
