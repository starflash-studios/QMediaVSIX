﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides the data from the ImagePreviewReceived event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerImagePreviewReceivedEventArgs : 
    IBarcodeScannerImagePreviewReceivedEventArgs
  {
    /// <summary>Gets the  from the device representing a preview frame.</summary>
    /// <returns>The data stream representing the preview frame.</returns>
    public extern IRandomAccessStreamWithContentType Preview { [MethodImpl] get; }
  }
}