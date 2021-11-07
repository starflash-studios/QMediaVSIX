// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaExtensionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (MediaExtensionManager))]
  [Guid(1243998965, 9261, 19963, 151, 244, 105, 183, 196, 37, 118, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaExtensionManager
  {
    [Overload("RegisterSchemeHandler")]
    void RegisterSchemeHandler(string activatableClassId, string scheme);

    [Overload("RegisterSchemeHandlerWithSettings")]
    void RegisterSchemeHandler(
      string activatableClassId,
      string scheme,
      IPropertySet configuration);

    [Overload("RegisterByteStreamHandler")]
    void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType);

    [Overload("RegisterByteStreamHandlerWithSettings")]
    void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType,
      IPropertySet configuration);

    [Overload("RegisterAudioDecoder")]
    void RegisterAudioDecoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterAudioDecoderWithSettings")]
    void RegisterAudioDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterAudioEncoder")]
    void RegisterAudioEncoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterAudioEncoderWithSettings")]
    void RegisterAudioEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterVideoDecoder")]
    void RegisterVideoDecoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterVideoDecoderWithSettings")]
    void RegisterVideoDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    [Overload("RegisterVideoEncoder")]
    void RegisterVideoEncoder(string activatableClassId, Guid inputSubtype, Guid outputSubtype);

    [Overload("RegisterVideoEncoderWithSettings")]
    void RegisterVideoEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);
  }
}
