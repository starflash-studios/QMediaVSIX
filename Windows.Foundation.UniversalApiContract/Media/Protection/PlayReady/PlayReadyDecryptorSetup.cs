// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyDecryptorSetup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Defines decryptor setup requirements indicating when to acquire licenses for the content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlayReadyDecryptorSetup
  {
    /// <summary>Indicates the DECRYPTORSETUP is not present in the rights management header. This indicates that a player app can guarantee that the license (chain) for the content is available prior to setting up the media graph.</summary>
    Uninitialized,
    /// <summary>Indicates that a player app cannot guarantee that the license (chain) for the content is available prior to setting up the media graph.</summary>
    OnDemand,
  }
}
