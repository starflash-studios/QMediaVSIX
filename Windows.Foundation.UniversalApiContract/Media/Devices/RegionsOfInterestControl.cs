// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.RegionsOfInterestControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality to mange the regions of interest on a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class RegionsOfInterestControl : IRegionsOfInterestControl
  {
    /// <summary>Gets the maximum number of regions of interest that can be specified.</summary>
    /// <returns>The maximum number of regions of interest.</returns>
    public extern uint MaxRegions { [MethodImpl] get; }

    [Overload("SetRegionsAsync")]
    [MethodImpl]
    public extern IAsyncAction SetRegionsAsync(IIterable<RegionOfInterest> regions);

    [Overload("SetRegionsWithLockAsync")]
    [MethodImpl]
    public extern IAsyncAction SetRegionsAsync(
      IIterable<RegionOfInterest> regions,
      bool lockValues);

    /// <summary>Asynchronously clears the regions of interests.</summary>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearRegionsAsync();

    /// <summary>Gets a value that specifies if auto focus is supported on the capture device.</summary>
    /// <returns>**true** if auto focus is supported; otherwise, **false**.</returns>
    public extern bool AutoFocusSupported { [MethodImpl] get; }

    /// <summary>Gets a value that specifies if auto white balance is supported on the capture device.</summary>
    /// <returns>**true** if auto white balance is supported; otherwise, **false**.</returns>
    public extern bool AutoWhiteBalanceSupported { [MethodImpl] get; }

    /// <summary>Gets a value that specifies if auto exposure is supported on the capture device.</summary>
    /// <returns>**true** if auto exposure is supported; otherwise, **false**.</returns>
    public extern bool AutoExposureSupported { [MethodImpl] get; }
  }
}
