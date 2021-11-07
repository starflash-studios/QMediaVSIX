// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ExposureControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the exposure settings on a capture device.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ExposureControl : IExposureControl
  {
    /// <summary>Gets a value that specifies if the capture device supports the exposure control.</summary>
    /// <returns>**true** if the exposure control is supported; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if auto exposure is enabled.</summary>
    /// <returns>**true** if auto exposure is enabled; otherwise, **false**.</returns>
    public extern bool Auto { [MethodImpl] get; }

    /// <summary>Asynchronously enables or disable auto exposure.</summary>
    /// <param name="value">Specifies whether or not to enable or disable auto exposure.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetAutoAsync(bool value);

    /// <summary>Gets the minimum exposure time.</summary>
    /// <returns>The minimum exposure time.</returns>
    public extern TimeSpan Min { [MethodImpl] get; }

    /// <summary>Gets the maximum exposure time.</summary>
    /// <returns>The maximum exposure time.</returns>
    public extern TimeSpan Max { [MethodImpl] get; }

    /// <summary>Gets the smallest exposure time increment supported by the capture device.</summary>
    /// <returns>The smallest exposure time increment.</returns>
    public extern TimeSpan Step { [MethodImpl] get; }

    /// <summary>Gets the exposure time.</summary>
    /// <returns>The exposure time.</returns>
    public extern TimeSpan Value { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(TimeSpan shutterDuration);
  }
}
