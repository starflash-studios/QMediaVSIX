// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.H264ProfileIds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Provides properties for getting H.264 profile ids.</summary>
  [Static(typeof (IH264ProfileIdsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class H264ProfileIds
  {
    /// <summary>Gets the H.264 constrained baseline profile.</summary>
    /// <returns>The constrained baseline profile.</returns>
    public static extern int ConstrainedBaseline { [MethodImpl] get; }

    /// <summary>Gets the H.264 baseline profile.</summary>
    /// <returns>The baseline profile.</returns>
    public static extern int Baseline { [MethodImpl] get; }

    /// <summary>Gets the H.264 extended profile.</summary>
    /// <returns>The extended profile.</returns>
    public static extern int Extended { [MethodImpl] get; }

    /// <summary>Gets the H.264 main profile.</summary>
    /// <returns>Gets the main profile.</returns>
    public static extern int Main { [MethodImpl] get; }

    /// <summary>Gets the H.264 high profile.</summary>
    /// <returns>The high profile.</returns>
    public static extern int High { [MethodImpl] get; }

    /// <summary>Gets the H.264 high 10 profile.</summary>
    /// <returns>The high 10 profile.</returns>
    public static extern int High10 { [MethodImpl] get; }

    /// <summary>Gets the H.264 high 4:2:2 profile.</summary>
    /// <returns>The high 4:2:2 profile.</returns>
    public static extern int High422 { [MethodImpl] get; }

    /// <summary>Gets the H.264 high 4:4:4 profile.</summary>
    /// <returns>The high 4:4:4 profile.</returns>
    public static extern int High444 { [MethodImpl] get; }

    /// <summary>Gets the H.264 stereo high profile.</summary>
    /// <returns>The stereo high profile.</returns>
    public static extern int StereoHigh { [MethodImpl] get; }

    /// <summary>Gets the H.264 multiview profile.</summary>
    /// <returns>The multiview profile.</returns>
    public static extern int MultiviewHigh { [MethodImpl] get; }
  }
}
