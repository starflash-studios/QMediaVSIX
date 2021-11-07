// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.VariablePhotoSequenceCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  /// <summary>Provides methods and events that enable the capture of variable photo sequences.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 167772160)]
  public sealed class VariablePhotoSequenceCapture : 
    IVariablePhotoSequenceCapture,
    IVariablePhotoSequenceCapture2
  {
    /// <summary>Starts the capturing of variable photo sequence frames.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    /// <summary>Stops the capturing of variable photo sequence frames.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    /// <summary>Asynchronously releases the VariablePhotoSequenceCapture object and resources used by the capture operation.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();

    /// <summary>Occurs when a frame of a variable photo sequence is captured.</summary>
    public extern event TypedEventHandler<VariablePhotoSequenceCapture, VariablePhotoCapturedEventArgs> PhotoCaptured;

    /// <summary>Occurs when the VariablePhotoSequenceCapture object stops capturing frames for a variable photo sequence.</summary>
    public extern event TypedEventHandler<VariablePhotoSequenceCapture, object> Stopped;

    /// <summary>Updates the frame control values of the variable photo sequence.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateSettingsAsync();
  }
}
