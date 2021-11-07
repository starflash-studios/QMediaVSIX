// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFramePresentationMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicFramePresentationMonitor))]
  [Guid(3397854572, 28590, 17038, 187, 131, 37, 223, 238, 81, 19, 107)]
  [Deprecated("Use HolographicFrameScanoutMonitor instead of HolographicFramePresentationMonitor. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IHolographicFramePresentationMonitor : IClosable
  {
    [Deprecated("Use HolographicFrameScanoutMonitor instead of HolographicFramePresentationMonitor. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IVectorView<HolographicFramePresentationReport> ReadReports();
  }
}
