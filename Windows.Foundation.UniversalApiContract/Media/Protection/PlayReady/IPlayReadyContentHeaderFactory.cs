// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  [Guid(3415722239, 46936, 18294, 191, 1, 33, 122, 139, 81, 11, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyContentHeaderFactory
  {
    PlayReadyContentHeader CreateInstanceFromWindowsMediaDrmHeader(
      [Range(0, 2147483647)] byte[] headerBytes,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    PlayReadyContentHeader CreateInstanceFromComponents(
      Guid contentKeyId,
      string contentKeyIdString,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    PlayReadyContentHeader CreateInstanceFromPlayReadyHeader(
      [Range(0, 2147483647)] byte[] headerBytes);
  }
}
