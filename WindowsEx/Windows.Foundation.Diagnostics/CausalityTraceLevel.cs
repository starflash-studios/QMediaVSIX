// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.CausalityTraceLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Specifies a logging level that listeners can use for trace filtering.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CausalityTraceLevel
  {
    /// <summary>Indicates all operations that are necessary to construct a causality chain, including all operations for job creation and completion and work item creation and completion.</summary>
    Required,
    /// <summary>Tracks operations that are not necessary to construct a causality chain but are interesting for developers.</summary>
    Important,
    /// <summary>Indicates operations that influence causality but are likely to be less interesting for developers, including actions like registering progress delegates.</summary>
    Verbose,
  }
}
