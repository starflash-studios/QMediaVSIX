﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerSetActiveSymbologiesRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Represents the request to set the barcode symbologies for the device to use.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class BarcodeScannerSetActiveSymbologiesRequest : 
    IBarcodeScannerSetActiveSymbologiesRequest,
    IBarcodeScannerSetActiveSymbologiesRequest2
  {
    /// <summary>Gets the barcode symbologies for the device to use.</summary>
    /// <returns>The specific symbologies to use.</returns>
    public extern IVectorView<uint> Symbologies { [MethodImpl] get; }

    /// <summary>Notifies the client app that the request was processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Notifies the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();

    /// <summary>Notifies the client that the request was not processed successfully.</summary>
    /// <param name="reason">An **Int32** error code that will be converted to an HRESULT and raised as an exception in the calling application. The following values are supported:</param>
    /// <returns>An asynchronous operation.</returns>
    [Overload("ReportFailedWithFailedReasonAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(int reason);

    /// <summary>Notifies the client that the request was not processed successfully.</summary>
    /// <param name="reason">An **Int32** error code that will be converted to an HRESULT and raised as an exception in the calling application. The following values are supported:</param>
    /// <param name="failedReasonDescription">A description of what caused the failure, for use in debugging.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(
      int reason,
      string failedReasonDescription);
  }
}