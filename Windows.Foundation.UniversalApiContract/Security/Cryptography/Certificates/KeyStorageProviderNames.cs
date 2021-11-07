// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyStorageProviderNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Defines several commonly used key storage provider names. You can use this class in the KeyStorageProviderName property on the CertificateRequestProperties class.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IKeyStorageProviderNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKeyStorageProviderNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KeyStorageProviderNames
  {
    /// <summary>Returns "Microsoft Passport Key Storage Provider" as the provider name.</summary>
    /// <returns>The provider name.</returns>
    public static extern string PassportKeyStorageProvider { [MethodImpl] get; }

    /// <summary>Returns "Microsoft Software Key Storage Provider" as the provider name.</summary>
    /// <returns>The provider name.</returns>
    public static extern string SoftwareKeyStorageProvider { [MethodImpl] get; }

    /// <summary>Returns "Microsoft Smart Card Key Storage Provider" as the provider name.</summary>
    /// <returns>The provider name.</returns>
    public static extern string SmartcardKeyStorageProvider { [MethodImpl] get; }

    /// <summary>Returns "Microsoft Platform Crypyto Key Storage Provider" as the provider name.</summary>
    /// <returns>The provider name.</returns>
    public static extern string PlatformKeyStorageProvider { [MethodImpl] get; }
  }
}
