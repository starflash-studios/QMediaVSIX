﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides data for the ESimWatcher.Removed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ESimRemovedEventArgs : IESimRemovedEventArgs
  {
    /// <summary>Gets the ESim instance that was removed from the device.</summary>
    /// <returns>The ESim instance that was removed from the device.</returns>
    public extern ESim ESim { [MethodImpl] get; }
  }
}