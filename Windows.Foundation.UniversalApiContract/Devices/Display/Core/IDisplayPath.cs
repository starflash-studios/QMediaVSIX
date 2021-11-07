// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayPath
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
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DisplayPath))]
  [Guid(3017791050, 29792, 23774, 129, 27, 213, 174, 159, 61, 159, 132)]
  internal interface IDisplayPath
  {
    DisplayView View { get; }

    DisplayTarget Target { get; }

    DisplayPathStatus Status { get; }

    IReference<SizeInt32> SourceResolution { get; set; }

    DirectXPixelFormat SourcePixelFormat { get; set; }

    bool IsStereo { get; set; }

    IReference<SizeInt32> TargetResolution { get; set; }

    IReference<DisplayPresentationRate> PresentationRate { get; set; }

    IReference<bool> IsInterlaced { get; set; }

    DisplayWireFormat WireFormat { get; set; }

    DisplayRotation Rotation { get; set; }

    DisplayPathScaling Scaling { get; set; }

    IVectorView<DisplayModeInfo> FindModes(DisplayModeQueryOptions flags);

    void ApplyPropertiesFromMode(DisplayModeInfo modeResult);

    IMap<Guid, object> Properties { get; }
  }
}
