// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingFieldFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Specifies the format of an event field.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LoggingFieldFormat
  {
    /// <summary>No format is specified.</summary>
    Default,
    /// <summary>The field is hidden.</summary>
    Hidden,
    /// <summary>The field contains a MBCS (8-bit character) string.</summary>
    String,
    /// <summary>A boolean field.</summary>
    Boolean,
    /// <summary>A hexadecimal field.</summary>
    Hexadecimal,
    /// <summary>A process identifier field.</summary>
    ProcessId,
    /// <summary>A thread identifier field.</summary>
    ThreadId,
    /// <summary>A port number field.</summary>
    Port,
    /// <summary>An Internet Protocol version 4 (IPv4) field.</summary>
    Ipv4Address,
    /// <summary>An Internet Protocol version 6 (IPv6) field.</summary>
    Ipv6Address,
    /// <summary>A socket address field.</summary>
    SocketAddress,
    /// <summary>An Extensible Markup Language (XML) field.</summary>
    Xml,
    /// <summary>A JavaScript Object Notation (JSON) field.</summary>
    Json,
    /// <summary>A 32-bit **Win32** error code.</summary>
    Win32Error,
    /// <summary>A 32-bit Windows **NTSTATUS** value.</summary>
    NTStatus,
    /// <summary>A 32-bit Windows **HRESULT** value.</summary>
    HResult,
    /// <summary>A 64-bit FILETIME value.</summary>
    FileTime,
    /// <summary>A signed value.</summary>
    Signed,
    /// <summary>An unsigned value.</summary>
    Unsigned,
  }
}
