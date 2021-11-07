// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (DisplayDevice))]
  [Guid(1072686348, 2368, 21693, 160, 47, 249, 199, 165, 54, 173, 96)]
  internal interface IDisplayDevice2
  {
    DisplayScanout CreateSimpleScanoutWithDirtyRectsAndOptions(
      DisplaySource source,
      DisplaySurface surface,
      uint subresourceIndex,
      uint syncInterval,
      IIterable<RectInt32> dirtyRects,
      DisplayScanoutOptions options);
  }
}
