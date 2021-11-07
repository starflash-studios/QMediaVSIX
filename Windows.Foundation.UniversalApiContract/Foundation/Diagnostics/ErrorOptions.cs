// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ErrorOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Specifies the type of diagnostic error reporting for a thread.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum ErrorOptions : uint
  {
    /// <summary>No error reporting occurs for the thread.</summary>
    None = 0,
    /// <summary>Exceptions are suppressed and not reported.</summary>
    SuppressExceptions = 1,
    /// <summary>Exceptions are reported.</summary>
    ForceExceptions = 2,
    /// <summary>Error information for SetErrorInfo is used.</summary>
    UseSetErrorInfo = 4,
    /// <summary>Error information for SetErrorInfo is suppressed and not reported.</summary>
    SuppressSetErrorInfo = 8,
  }
}
