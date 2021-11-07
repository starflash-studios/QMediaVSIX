// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AdvancedPhotoCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Represents settings for an AdvancedPhotoControl object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdvancedPhotoCaptureSettings : IAdvancedPhotoCaptureSettings
  {
    /// <summary>Initializes a new instance of the AdvancedPhotoCaptureSettings class.</summary>
    [MethodImpl]
    public extern AdvancedPhotoCaptureSettings();

    /// <summary>Gets or sets the advanced capture mode for which an AdvancedPhotoControl will be configured.</summary>
    /// <returns>The advanced capture mode for which an AdvancedPhotoControl will be configured.</returns>
    public extern AdvancedPhotoMode Mode { [MethodImpl] get; [MethodImpl] set; }
  }
}
