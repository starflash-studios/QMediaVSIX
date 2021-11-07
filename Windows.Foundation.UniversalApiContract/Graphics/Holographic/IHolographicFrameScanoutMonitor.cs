// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFrameScanoutMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(2122575785, 33852, 21505, 128, 149, 155, 193, 184, 176, 134, 56)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (HolographicFrameScanoutMonitor))]
  internal interface IHolographicFrameScanoutMonitor : IClosable
  {
    IVector<HolographicFrameScanoutReport> ReadReports();
  }
}
