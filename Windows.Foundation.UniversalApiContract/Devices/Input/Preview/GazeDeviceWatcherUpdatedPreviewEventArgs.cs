﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeDeviceWatcherUpdatedPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Provides event data for the GazeDeviceWatcherPreview.Updated event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class GazeDeviceWatcherUpdatedPreviewEventArgs : 
    IGazeDeviceWatcherUpdatedPreviewEventArgs
  {
    /// <summary>Gets a reference to the eye-tracker device being monitored through the GazeDeviceWatcherPreview object.</summary>
    /// <returns>
    /// </returns>
    public extern GazeDevicePreview Device { [MethodImpl] get; }
  }
}