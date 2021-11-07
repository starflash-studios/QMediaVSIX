// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSampleProtectionProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a collection properties that are specific to the Digital Rights Management (DRM) protection of the MediaStreamSample.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class MediaStreamSampleProtectionProperties : IMediaStreamSampleProtectionProperties
  {
    /// <summary>Sets the Digital Rights Management (DRM) key identifier for the MediaStreamSample.</summary>
    /// <param name="value">The value to set the Digital Rights Management (DRM) key identifier to.</param>
    [MethodImpl]
    public extern void SetKeyIdentifier(byte[] value);

    /// <summary>Gets the Digital Rights Management (DRM) key identifier from the MediaStreamSample.</summary>
    /// <param name="value">Receives the key identifier used to decrypt the data.</param>
    [MethodImpl]
    public extern void GetKeyIdentifier(out byte[] value);

    /// <summary>Sets the Digital Rights Management (DRM) initialization vector for the MediaStreamSample.</summary>
    /// <param name="value">The value to set the Digital Rights Management (DRM) initialization vector to.</param>
    [MethodImpl]
    public extern void SetInitializationVector(byte[] value);

    /// <summary>Gets the Digital Rights Management (DRM) initialization vector from the MediaStreamSample.</summary>
    /// <param name="value">The initialization vector.</param>
    [MethodImpl]
    public extern void GetInitializationVector(out byte[] value);

    /// <summary>Sets the Digital Rights Management (DRM) sub-sample mapping for the MediaStreamSample.</summary>
    /// <param name="value">The value to set the Digital Rights Management (DRM) sub-sample mapping to.</param>
    [MethodImpl]
    public extern void SetSubSampleMapping(byte[] value);

    /// <summary>Gets the Digital Rights Management (DRM) sub-sample mapping from the MediaStreamSample.</summary>
    /// <param name="value">Receives the sub-sample mapping.</param>
    [MethodImpl]
    public extern void GetSubSampleMapping(out byte[] value);
  }
}
