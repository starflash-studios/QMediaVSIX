﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToSourceDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Represents a deferred operation when you're supplying a source media element for Play To.</summary>
  /// <deprecated type="deprecate">PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.</deprecated>
  [Deprecated("PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToSourceDeferral : IPlayToSourceDeferral
  {
    /// <summary>Ends the deferral.</summary>
    /// <deprecated type="deprecate">PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.</deprecated>
    [Deprecated("PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Complete();
  }
}