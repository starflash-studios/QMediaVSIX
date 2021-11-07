// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(2588117610, 32588, 17710, 136, 189, 1, 72, 198, 56, 122, 44)]
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyContentHeader
  {
    Guid KeyId { get; }

    string KeyIdString { get; }

    global::Windows.Foundation.Uri LicenseAcquisitionUrl { get; }

    global::Windows.Foundation.Uri LicenseAcquisitionUserInterfaceUrl { get; }

    Guid DomainServiceId { get; }

    PlayReadyEncryptionAlgorithm EncryptionType { get; }

    string CustomAttributes { get; }

    PlayReadyDecryptorSetup DecryptorSetup { get; }

    byte[] GetSerializedHeader();

    PlayReadyContentHeader HeaderWithEmbeddedUpdates { get; }
  }
}
