// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayModeInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.Devices.Display.Core
{
  [Guid(1221923744, 63387, 23156, 160, 94, 218, 130, 31, 71, 8, 104)]
  [ExclusiveTo(typeof (DisplayModeInfo))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayModeInfo
  {
    SizeInt32 SourceResolution { get; }

    bool IsStereo { get; }

    DirectXPixelFormat SourcePixelFormat { get; }

    SizeInt32 TargetResolution { get; }

    DisplayPresentationRate PresentationRate { get; }

    bool IsInterlaced { get; }

    DisplayBitsPerChannel GetWireFormatSupportedBitsPerChannel(
      DisplayWireFormatPixelEncoding encoding);

    bool IsWireFormatSupported(DisplayWireFormat wireFormat);

    IMapView<Guid, object> Properties { get; }
  }
}
