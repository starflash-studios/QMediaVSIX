// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemVideoProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for video file properties.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SystemVideoProperties : ISystemVideoProperties
  {
    /// <summary>Gets the name of the System.Video.Director property (one of the Windows video file properties.</summary>
    /// <returns>The name of the System.Video.Director file property.</returns>
    public extern string Director { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Video.FrameHeight property (one of the Windows video file properties.</summary>
    /// <returns>The name of the System.Video.FrameHeight file property.</returns>
    public extern string FrameHeight { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Video.FrameWidth property (one of the Windows video file properties.</summary>
    /// <returns>The name of the System.Video.FrameWidth file property.</returns>
    public extern string FrameWidth { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Video.Orientation property (one of the Windows video file properties.</summary>
    /// <returns>The name of the System.Video.Orientation file property.</returns>
    public extern string Orientation { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Video.TotalBitrate property (one of the Windows video file properties.</summary>
    /// <returns>The name of the System.Video.TotalBitrate file property.</returns>
    public extern string TotalBitrate { [MethodImpl] get; }
  }
}
