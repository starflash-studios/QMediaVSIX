// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameControlCapabilities2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameControlCapabilities))]
  [Guid(3466265700, 18224, 17423, 189, 62, 239, 232, 168, 242, 48, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameControlCapabilities2
  {
    FrameFlashCapabilities Flash { get; }
  }
}
