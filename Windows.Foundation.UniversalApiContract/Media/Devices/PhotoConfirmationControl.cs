// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.PhotoConfirmationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the photo confirmation settings on a capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoConfirmationControl : IPhotoConfirmationControl
  {
    /// <summary>Gets a value indicating whether photo confirmation is supported by the capture device.</summary>
    /// <returns>A value indicating whether photo confirmation is supported by the capture device.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether photo confirmation is enabled.</summary>
    /// <returns>A value indicating whether photo confirmation is enabled.</returns>
    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the desired pixel format for photo confirmation frames.</summary>
    /// <returns>The desired pixel format for photo confirmation frames.</returns>
    public extern MediaPixelFormat PixelFormat { [MethodImpl] get; [MethodImpl] set; }
  }
}
