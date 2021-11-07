﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  /// <summary>Describes the reason background execution was revoked.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ExtendedExecutionRevokedReason
  {
    /// <summary>The app was resumed while it was executing in the background.</summary>
    Resumed,
    /// <summary>Background execution is revoked due to system resources.</summary>
    SystemPolicy,
  }
}