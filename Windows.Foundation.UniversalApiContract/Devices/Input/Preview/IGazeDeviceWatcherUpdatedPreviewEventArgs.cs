// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.IGazeDeviceWatcherUpdatedPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  [WebHostHidden]
  [Guid(2145923311, 32520, 18231, 136, 225, 74, 131, 174, 78, 72, 133)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (GazeDeviceWatcherUpdatedPreviewEventArgs))]
  internal interface IGazeDeviceWatcherUpdatedPreviewEventArgs
  {
    GazeDevicePreview Device { get; }
  }
}
