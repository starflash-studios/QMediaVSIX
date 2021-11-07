// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.IGazeInputSourcePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GazeInputSourcePreview))]
  [Guid(3885924072, 45961, 4583, 178, 1, 200, 211, 255, 183, 87, 33)]
  internal interface IGazeInputSourcePreview
  {
    event TypedEventHandler<GazeInputSourcePreview, GazeMovedPreviewEventArgs> GazeMoved;

    event TypedEventHandler<GazeInputSourcePreview, GazeEnteredPreviewEventArgs> GazeEntered;

    event TypedEventHandler<GazeInputSourcePreview, GazeExitedPreviewEventArgs> GazeExited;
  }
}
