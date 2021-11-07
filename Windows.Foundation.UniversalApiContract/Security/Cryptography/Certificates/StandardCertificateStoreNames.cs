// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.StandardCertificateStoreNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Provides properties for retrieving standard certificate store names.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IStandardCertificateStoreNamesStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public static class StandardCertificateStoreNames
  {
    /// <summary>Gets the name of the personal certificate store.</summary>
    /// <returns>The name of the personal certificate store.</returns>
    public static extern string Personal { [MethodImpl] get; }

    /// <summary>Gets the name of the trusted root certificate authorities.</summary>
    /// <returns>The name of the trusted root certificate authorities.</returns>
    public static extern string TrustedRootCertificationAuthorities { [MethodImpl] get; }

    /// <summary>Gets the name of the intermediate certificate authorities.</summary>
    /// <returns>The name of the intermediate certificate authorities.</returns>
    public static extern string IntermediateCertificationAuthorities { [MethodImpl] get; }
  }
}
