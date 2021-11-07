// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.InputStreamOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Specifies the read options for an input stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum InputStreamOptions : uint
  {
    /// <summary>No options are specified.</summary>
    None = 0,
    /// <summary>The asynchronous read operation completes when one or more bytes is available.</summary>
    Partial = 1,
    /// <summary>The asynchronous read operation may optionally read ahead and prefetch additional bytes.</summary>
    ReadAhead = 2,
  }
}
