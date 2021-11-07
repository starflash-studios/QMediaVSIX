// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Represents the result of an operation to get the value of a video device controller driver property.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VideoDeviceControllerGetDevicePropertyResult : 
    IVideoDeviceControllerGetDevicePropertyResult
  {
    /// <summary>Gets a value that specifies the status of an operation to get the value of a video device controller driver property.</summary>
    /// <returns>A value specifythat specifies the status of an operation to get the value of a video device controller driver property.</returns>
    public extern VideoDeviceControllerGetDevicePropertyStatus Status { [MethodImpl] get; }

    /// <summary>Gets an object representing the result value of an operation to get the value of a video device controller driver property.</summary>
    /// <returns>An object representing the result value of an operation to get the value of a video device controller driver property. If the value of Status is not **Success**, this value will be null.</returns>
    public extern object Value { [MethodImpl] [return: Variant] get; }
  }
}
