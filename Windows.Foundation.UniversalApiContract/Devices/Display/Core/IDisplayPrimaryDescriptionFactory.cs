// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayPrimaryDescriptionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Devices.Display.Core
{
  [Guid(443219835, 13879, 23622, 180, 121, 118, 213, 118, 33, 110, 101)]
  [ExclusiveTo(typeof (DisplayPrimaryDescription))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayPrimaryDescriptionFactory
  {
    DisplayPrimaryDescription CreateInstance(
      uint width,
      uint height,
      DirectXPixelFormat pixelFormat,
      DirectXColorSpace colorSpace,
      bool isStereo,
      Direct3DMultisampleDescription multisampleDescription);
  }
}
