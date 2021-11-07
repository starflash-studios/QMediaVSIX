﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides information about an operation status change.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MagneticStripeReaderStatusUpdatedEventArgs : 
    IMagneticStripeReaderStatusUpdatedEventArgs
  {
    /// <summary>Gets the status change information.</summary>
    /// <returns>The status change information.</returns>
    public extern MagneticStripeReaderStatus Status { [MethodImpl] get; }

    /// <summary>Gets the vendor specific error code.</summary>
    /// <returns>The vendor specific error code.</returns>
    public extern uint ExtendedStatus { [MethodImpl] get; }
  }
}