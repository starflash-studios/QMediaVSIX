// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFrameScanoutReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicFrameScanoutReport))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(247195142, 928, 23712, 180, 110, 187, 160, 104, 215, 35, 63)]
  internal interface IHolographicFrameScanoutReport
  {
    HolographicFrameRenderingReport RenderingReport { get; }

    uint MissedScanoutCount { get; }

    TimeSpan SystemRelativeLatchTime { get; }

    TimeSpan SystemRelativeScanoutStartTime { get; }

    TimeSpan SystemRelativePhotonTime { get; }
  }
}
