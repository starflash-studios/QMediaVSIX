// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.SpatialAudioFormatSubtype
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Helper class to retrieve the GUIDs for known spatial audio formats.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (ISpatialAudioFormatSubtypeStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISpatialAudioFormatSubtypeStatics2), 786432, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public static class SpatialAudioFormatSubtype
  {
    public static extern string DTSXForHomeTheater { [MethodImpl] get; }

    /// <summary>GUID for WindowsSonic.</summary>
    /// <returns>A string representation of the format's GUID.</returns>
    public static extern string WindowsSonic { [MethodImpl] get; }

    /// <summary>GUID for DolbyAtmosForHeadphones.</summary>
    /// <returns>A string representation of the format's GUID.</returns>
    public static extern string DolbyAtmosForHeadphones { [MethodImpl] get; }

    /// <summary>GUID for DolbyAtmosForHomeTheater.</summary>
    /// <returns>A string representation of the format's GUID.</returns>
    public static extern string DolbyAtmosForHomeTheater { [MethodImpl] get; }

    /// <summary>GUID for DolbyAtmosForSpeakers.</summary>
    /// <returns>A string representation of the format's GUID.</returns>
    public static extern string DolbyAtmosForSpeakers { [MethodImpl] get; }

    /// <summary>GUID for DTSHeadphoneX.</summary>
    /// <returns>A string representation of the format's GUID.</returns>
    public static extern string DTSHeadphoneX { [MethodImpl] get; }

    /// <summary>GUID for DTSXUltra.</summary>
    /// <returns>A string representation of the format's GUID.</returns>
    public static extern string DTSXUltra { [MethodImpl] get; }
  }
}
