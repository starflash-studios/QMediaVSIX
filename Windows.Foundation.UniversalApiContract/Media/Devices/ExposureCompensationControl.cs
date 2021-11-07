// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ExposureCompensationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for modifying exposure levels of captured photos.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 100859904)]
  public sealed class ExposureCompensationControl : IExposureCompensationControl
  {
    /// <summary>Gets a value that specifies if the capture device supports the exposure compensation control.</summary>
    /// <returns>**true** if the exposure compensation control is supported; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the minimum exposure time.</summary>
    /// <returns>The minimum exposure time.</returns>
    public extern float Min { [MethodImpl] get; }

    /// <summary>Gets the maximum exposure time.</summary>
    /// <returns>The maximum exposure time.</returns>
    public extern float Max { [MethodImpl] get; }

    /// <summary>Gets the smallest exposure compensation increment supported by the capture device.</summary>
    /// <returns>The smallest exposure compensation increment.</returns>
    public extern float Step { [MethodImpl] get; }

    /// <summary>Gets the exposure compensation level.</summary>
    /// <returns>The exposure time.</returns>
    public extern float Value { [MethodImpl] get; }

    /// <summary>Asynchronously sets the exposure compensation.</summary>
    /// <param name="value">The exposure compensation level to set the Value property to. The minimum and maximum values are specified by Min and Max.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(float value);
  }
}
