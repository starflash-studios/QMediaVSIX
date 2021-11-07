// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeaderFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3508772085, 44653, 18296, 151, 253, 110, 58, 46, 234, 219, 235)]
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  internal interface IPlayReadyContentHeaderFactory2
  {
    PlayReadyContentHeader CreateInstanceFromComponents2(
      uint dwFlags,
      [Range(0, 2147483647)] Guid[] contentKeyIds,
      [Range(0, 2147483647)] string[] contentKeyIdStrings,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      global::Windows.Foundation.Uri licenseAcquisitionUrl,
      global::Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);
  }
}
