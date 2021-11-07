// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.Mpeg2ProfileIds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Provides properties for getting MPEG-2 profile ids.</summary>
  [Static(typeof (IMpeg2ProfileIdsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class Mpeg2ProfileIds
  {
    /// <summary>Gets the MPEG-2 simple profile.</summary>
    /// <returns>The MPEG-2 simple profile.</returns>
    public static extern int Simple { [MethodImpl] get; }

    /// <summary>Gets the MPEG-2 main profile.</summary>
    /// <returns>The MPEG-2 main profile.</returns>
    public static extern int Main { [MethodImpl] get; }

    /// <summary>Gets the MPEG-2 signal to noise ratio scalable profile.</summary>
    /// <returns>The MPEG-2 signal to noise ratio scalable profile.</returns>
    public static extern int SignalNoiseRatioScalable { [MethodImpl] get; }

    /// <summary>Gets the MPEG-2 spatially scalable profile.</summary>
    /// <returns>The MPEG-2 spatially scalable profile.</returns>
    public static extern int SpatiallyScalable { [MethodImpl] get; }

    /// <summary>Gets the MPEG-2 high profile.</summary>
    /// <returns>The MPEG-2 high profile.</returns>
    public static extern int High { [MethodImpl] get; }
  }
}
