// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketSslErrorSeverity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>The category of error that occurs on an SSL connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketSslErrorSeverity
  {
    /// <summary>No error occurs on the SSL connection.</summary>
    None,
    /// <summary>Ignorable errors indicate that the SSL server’s certificate cannot be properly validated.</summary>
    Ignorable,
    /// <summary>Fatal errors indicate the SSL server’s certificate cannot be validated. Reasons for encountering this severity level include:</summary>
    Fatal,
  }
}
