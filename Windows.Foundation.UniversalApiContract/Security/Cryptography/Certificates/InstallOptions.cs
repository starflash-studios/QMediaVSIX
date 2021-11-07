// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.InstallOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Specifies certificate installation options. This enumeration type is used by the InstallCertificateAsync and ImportPfxDataAsync methods.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InstallOptions : uint
  {
    /// <summary>No options are specified.</summary>
    None = 0,
    /// <summary>Delete expired certificates.</summary>
    DeleteExpired = 1,
  }
}
