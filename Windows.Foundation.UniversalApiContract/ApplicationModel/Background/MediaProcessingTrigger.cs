// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.MediaProcessingTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task for performing media processing.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaProcessingTrigger : IMediaProcessingTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of the MediaProcessingTrigger class.</summary>
    [MethodImpl]
    public extern MediaProcessingTrigger();

    /// <summary>Triggers the background task and returns a MediaProcessingTriggerResult indicating success or failure of the trigger request.</summary>
    /// <returns>An asynchronous operation that returns a MediaProcessingTriggerResult upon completion.</returns>
    [Overload("RequestAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaProcessingTriggerResult> RequestAsync();

    /// <summary>Triggers the background task with the provided collection of arguments and returns a MediaProcessingTriggerResult indicating success or failure of the trigger request.</summary>
    /// <param name="arguments">A collection of arguments that will be passed to the media processing background task.</param>
    /// <returns>An asynchronous operation that returns a MediaProcessingTriggerResult upon completion.</returns>
    [Overload("RequestAsyncWithArguments")]
    [MethodImpl]
    public extern IAsyncOperation<MediaProcessingTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
