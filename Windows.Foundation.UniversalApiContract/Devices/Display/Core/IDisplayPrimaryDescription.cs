// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayPrimaryDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Devices.Display.Core
{
  [Guid(2267386322, 54579, 20735, 168, 94, 6, 105, 97, 148, 183, 124)]
  [ExclusiveTo(typeof (DisplayPrimaryDescription))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayPrimaryDescription
  {
    uint Width { get; }

    uint Height { get; }

    DirectXPixelFormat Format { get; }

    DirectXColorSpace ColorSpace { get; }

    bool IsStereo { get; }

    Direct3DMultisampleDescription MultisampleDescription { get; }

    IMapView<Guid, object> Properties { get; }
  }
}
