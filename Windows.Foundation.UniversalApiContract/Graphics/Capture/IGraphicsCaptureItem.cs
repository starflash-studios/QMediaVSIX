// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GraphicsCaptureItem))]
  [Guid(2042886491, 12791, 20162, 164, 100, 99, 46, 245, 211, 7, 96)]
  internal interface IGraphicsCaptureItem
  {
    string DisplayName { get; }

    SizeInt32 Size { get; }

    event TypedEventHandler<GraphicsCaptureItem, object> Closed;
  }
}
