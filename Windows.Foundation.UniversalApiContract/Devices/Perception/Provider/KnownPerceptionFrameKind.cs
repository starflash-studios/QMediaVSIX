// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.KnownPerceptionFrameKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>A string used to identify the type classification of a frame.</summary>
  /// <deprecated type="deprecate">KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Threading(ThreadingModel.Both)]
  [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownPerceptionFrameKindStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class KnownPerceptionFrameKind
  {
    /// <summary>Gets the string representing the Color FrameKind of a PerceptionFrameProviderInfo.</summary>
    /// <returns>The string representing the Color FrameKind of a PerceptionFrameProviderInfo.</returns>
    public static extern string Color { [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the string representing the Depth FrameKind of a PerceptionFrameProviderInfo.</summary>
    /// <returns>The string representing the Depth FrameKind of a PerceptionFrameProviderInfo.</returns>
    public static extern string Depth { [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the string representing the Infrared FrameKind of a PerceptionFrameProviderInfo.</summary>
    /// <returns>The string representing the Infrared FrameKind of a PerceptionFrameProviderInfo.</returns>
    public static extern string Infrared { [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
