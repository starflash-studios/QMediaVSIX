// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IHdrVideoControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HdrVideoControl))]
  [Guid(1440277200, 12480, 17343, 155, 154, 151, 153, 215, 12, 237, 148)]
  internal interface IHdrVideoControl
  {
    bool Supported { get; }

    IVectorView<HdrVideoMode> SupportedModes { get; }

    HdrVideoMode Mode { get; set; }
  }
}
