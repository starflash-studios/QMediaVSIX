// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IHighDynamicRangeOutput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Core
{
  [Guid(257392747, 9531, 16665, 187, 64, 58, 144, 229, 19, 132, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HighDynamicRangeOutput))]
  internal interface IHighDynamicRangeOutput
  {
    double Certainty { get; }

    IVectorView<FrameController> FrameControllers { get; }
  }
}
