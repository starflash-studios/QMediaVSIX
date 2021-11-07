// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFlashControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (FlashControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2099891358, 30177, 19191, 189, 125, 78, 56, 225, 192, 108, 214)]
  internal interface IFlashControl2
  {
    bool AssistantLightSupported { get; }

    bool AssistantLightEnabled { get; set; }
  }
}
