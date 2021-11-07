// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayPrimaryDescriptionStatics
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
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3859696891, 14025, 22237, 143, 161, 111, 248, 196, 224, 255, 7)]
  [ExclusiveTo(typeof (DisplayPrimaryDescription))]
  internal interface IDisplayPrimaryDescriptionStatics
  {
    DisplayPrimaryDescription CreateWithProperties(
      IIterable<IKeyValuePair<Guid, object>> extraProperties,
      uint width,
      uint height,
      DirectXPixelFormat pixelFormat,
      DirectXColorSpace colorSpace,
      bool isStereo,
      Direct3DMultisampleDescription multisampleDescription);
  }
}
