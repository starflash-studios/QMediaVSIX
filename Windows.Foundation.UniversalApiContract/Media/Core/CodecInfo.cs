// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.CodecInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides information about a media codec that is installed on the system.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  public sealed class CodecInfo : ICodecInfo
  {
    /// <summary>Gets a value specifying whether the codec operates on audio or video data.</summary>
    /// <returns>A value specifying whether the codec operates on audio or video data.</returns>
    public extern CodecKind Kind { [MethodImpl] get; }

    /// <summary>Gets a value that specifies whether the codec is an encoder or a decoder.</summary>
    /// <returns>A value that specifies whether the codec is an encoder or a decoder.</returns>
    public extern CodecCategory Category { [MethodImpl] get; }

    /// <summary>Gets a read-only list of values that specify the media subtypes supported by the codec.</summary>
    /// <returns>A read-only list of values that specify the media subtypes supported by the codec.</returns>
    public extern IVectorView<string> Subtypes { [MethodImpl] get; }

    /// <summary>Gets the friendly display name for the codec.</summary>
    /// <returns>The friendly display name for the codec.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the codec runs in your app's process space rather than in a separate app service.</summary>
    /// <returns>True if the codec is runs in the app process space; false if the codec runs in a separate app service.</returns>
    public extern bool IsTrusted { [MethodImpl] get; }
  }
}
