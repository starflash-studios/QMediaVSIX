// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a certificate extension.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  public sealed class CertificateExtension : ICertificateExtension
  {
    /// <summary>Creates a new certificateExtension object.</summary>
    [MethodImpl]
    public extern CertificateExtension();

    /// <summary>Gets or sets the object ID.</summary>
    /// <returns>The object ID.</returns>
    public extern string ObjectId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a boolean indicating if the certificate extension is critical.</summary>
    /// <returns>A boolean indicating if the certificate extension is critical.</returns>
    public extern bool IsCritical { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Encodes the string value into the value byte array.</summary>
    /// <param name="value">The string value to encode.</param>
    [MethodImpl]
    public extern void EncodeValue(string value);

    /// <summary>Gets or sets the value of the certificate extension.</summary>
    /// <returns>The value of the certificate extension.</returns>
    public extern byte[] Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
