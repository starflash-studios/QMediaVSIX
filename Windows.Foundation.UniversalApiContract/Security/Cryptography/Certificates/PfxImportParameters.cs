// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.PfxImportParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents PFX import parameters.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PfxImportParameters : IPfxImportParameters
  {
    /// <summary>Creates a new instance of the PfxImportParameters class.</summary>
    [MethodImpl]
    public extern PfxImportParameters();

    /// <summary>Gets or sets the export option.</summary>
    /// <returns>The export option.</returns>
    public extern ExportOption Exportable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the key protection level.</summary>
    /// <returns>The key protection level.</returns>
    public extern KeyProtectionLevel KeyProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the install options.</summary>
    /// <returns>The install options.</returns>
    public extern InstallOptions InstallOptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the friendly name.</summary>
    /// <returns>The friendly name.</returns>
    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the key storage provider name.</summary>
    /// <returns>The key storage provider name.</returns>
    public extern string KeyStorageProviderName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the container name prefix.</summary>
    /// <returns>The container name prefix.</returns>
    public extern string ContainerNamePrefix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the reader name.</summary>
    /// <returns>The reader name.</returns>
    public extern string ReaderName { [MethodImpl] get; [MethodImpl] set; }
  }
}
