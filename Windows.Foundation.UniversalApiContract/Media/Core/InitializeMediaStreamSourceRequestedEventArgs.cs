// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.InitializeMediaStreamSourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the InitializeMediaStreamSourceRequested event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class InitializeMediaStreamSourceRequestedEventArgs : 
    IInitializeMediaStreamSourceRequestedEventArgs
  {
    /// <summary>Gets the uninitialized MediaStreamSource object that the app service should initialize and use to provide samples to the requesting app.</summary>
    /// <returns>The uninitialized **MediaStreamSource** object.</returns>
    public extern MediaStreamSource Source { [MethodImpl] get; }

    /// <summary>Gets the IRandomAccessStream associated with the media stream source request.</summary>
    /// <returns>The **IRandomAccessStream** associated with the media stream source request.</returns>
    public extern IRandomAccessStream RandomAccessStream { [MethodImpl] get; }

    /// <summary>Gets a Deferral object that instructs the system to wait for the app service to complete media source stream initialization before continuing processing the request.</summary>
    /// <returns>A **Deferral** object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
