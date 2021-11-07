// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyContentHeader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Represents the information in a PlayReady content header.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPlayReadyContentHeaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IPlayReadyContentHeaderFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadyContentHeader : IPlayReadyContentHeader, IPlayReadyContentHeader2
  {
    [MethodImpl]
    public extern PlayReadyContentHeader(
      uint dwFlags,
      [Range(0, 2147483647)] Guid[] contentKeyIds,
      [Range(0, 2147483647)] string[] contentKeyIdStrings,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader(
      [Range(0, 2147483647)] byte[] headerBytes,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader(
      Guid contentKeyId,
      string contentKeyIdString,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    /// <summary>Initializes a new instance of the PlayReadyContentHeader class.</summary>
    /// <param name="headerBytes">Raw data bytes representing a PlayReady content header.</param>
    [MethodImpl]
    public extern PlayReadyContentHeader([Range(0, 2147483647)] byte[] headerBytes);

    /// <summary>Gets the content key identifier value if it is set.</summary>
    /// <returns>The content key identifier. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid KeyId { [MethodImpl] get; }

    /// <summary>Gets the content key identifier string value if it is set.</summary>
    /// <returns>The content key identifier string.</returns>
    public extern string KeyIdString { [MethodImpl] get; }

    /// <summary>Gets the license acquisition URL in the header if it is set.</summary>
    /// <returns>The license acquisition URL.</returns>
    public extern global::Windows.Foundation.Uri LicenseAcquisitionUrl { [MethodImpl] get; }

    /// <summary>Gets the license acquisition user interface URL in the header if it is set.</summary>
    /// <returns>The license acquisition user interface URL.</returns>
    public extern global::Windows.Foundation.Uri LicenseAcquisitionUserInterfaceUrl { [MethodImpl] get; }

    /// <summary>Gets the domain service identifier in the header if it is set.</summary>
    /// <returns>The header's domain service identifier. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid DomainServiceId { [MethodImpl] get; }

    /// <summary>Gets the content encryption type in the header if it is set.</summary>
    /// <returns>The header's content encryption type.</returns>
    public extern PlayReadyEncryptionAlgorithm EncryptionType { [MethodImpl] get; }

    /// <summary>Gets the custom data used by the content provider.</summary>
    /// <returns>The custom data used by the content provider.</returns>
    public extern string CustomAttributes { [MethodImpl] get; }

    /// <summary>Gets the decryptor setup value in the header if it is set.</summary>
    /// <returns>The header's decryptor setup value.</returns>
    public extern PlayReadyDecryptorSetup DecryptorSetup { [MethodImpl] get; }

    /// <summary>Retrieves the full PlayReady object as a byte array.</summary>
    /// <returns>The header containing the full PlayReady object.</returns>
    [MethodImpl]
    public extern byte[] GetSerializedHeader();

    /// <summary>Gets a new content header that contains any embedded license updates that were available.</summary>
    /// <returns>The new content header. If updates were not available, then this property returns **NULL**.</returns>
    public extern PlayReadyContentHeader HeaderWithEmbeddedUpdates { [MethodImpl] get; }

    /// <summary>Gets the content key identifier values if they are set.</summary>
    /// <returns>The content key identifier values. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid[] KeyIds { [MethodImpl] get; }

    /// <summary>Gets the content key identifier string values if they are set.</summary>
    /// <returns>The content key identifier string values.</returns>
    public extern string[] KeyIdStrings { [MethodImpl] get; }
  }
}
