// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [Guid(3268450902, 1551, 17601, 184, 226, 31, 191, 96, 189, 98, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocketControl))]
  internal interface IStreamSocketControl2
  {
    IVector<ChainValidationResult> IgnorableServerCertificateErrors { get; }
  }
}
