﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerGetSymbologyAttributesRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Represents the request to get attributes of a barcode symbology.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerGetSymbologyAttributesRequest : 
    IBarcodeScannerGetSymbologyAttributesRequest,
    IBarcodeScannerGetSymbologyAttributesRequest2
  {
    /// <summary>Gets the barcode symbology.  Possible values are defined in the BarcodeSymbologies class.</summary>
    /// <returns>The specific barcode symbology.</returns>
    public extern uint Symbology { [MethodImpl] get; }

    /// <summary>Notifies the client app that the request was processed successfully.</summary>
    /// <param name="attributes">The attributes of the requested barcode symbology.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(
      BarcodeSymbologyAttributes attributes);

    /// <summary>Notifies the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();

    /// <summary>Notifies the client that the request was not processed successfully.</summary>
    /// <param name="reason">An **Int32** error code that will be converted to an HRESULT and raised as an exception in the calling application. The following values are supported:</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAsync")]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(int reason);

    /// <summary>Notifies the client that the request was not processed successfully.</summary>
    /// <param name="reason">An **Int32** error code that will be converted to an HRESULT and raised as an exception in the calling application. The following values are supported:</param>
    /// <param name="failedReasonDescription">A description of what caused the failure, for use in debugging.</param>
    /// <returns>An asynchronous operation.</returns>
    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(
      int reason,
      string failedReasonDescription);
  }
}