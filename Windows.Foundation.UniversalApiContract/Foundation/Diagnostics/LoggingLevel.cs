// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Specifies the severity level of an event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LoggingLevel
  {
    /// <summary>Log all messages.</summary>
    Verbose,
    /// <summary>Log messages of information level and higher.</summary>
    Information,
    /// <summary>Log messages of warning level and higher.</summary>
    Warning,
    /// <summary>Log messages of error level and higher.</summary>
    Error,
    /// <summary>Log only critical messages.</summary>
    Critical,
  }
}
