﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SuspendingOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides info about an app suspending operation.</summary>
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SuspendingOperation : ISuspendingOperation
  {
    /// <summary>Requests that the app suspending operation be delayed.</summary>
    /// <returns>The suspension deferral.</returns>
    [MethodImpl]
    public extern SuspendingDeferral GetDeferral();

    /// <summary>Gets the time when the delayed app suspending operation continues.</summary>
    /// <returns>The time.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }
  }
}