// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ExposurePriorityVideoControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>When supported, allows an app to specify whether the camera driver can dynamically adjust the frame rate of video capture in order to improve video quality in low-light conditions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ExposurePriorityVideoControl : IExposurePriorityVideoControl
  {
    /// <summary>Gets or sets a value that specifies if ExposurePriorityVideoControl is supported on the current device.</summary>
    /// <returns>True if the ExposurePriorityVideoControl is supported; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies if ExposurePriorityVideoControl is enabled.</summary>
    /// <returns>True if ExposurePriorityVideoControl is enabled; otherwise, false.</returns>
    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
