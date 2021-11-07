// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ApplicationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>This allows you to programmatically trigger a background task from within your application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationTrigger : IApplicationTrigger, IBackgroundTrigger
  {
    /// <summary>Creates a new ApplicationTrigger class</summary>
    [MethodImpl]
    public extern ApplicationTrigger();

    /// <summary>This method attempts to set the trigger and start the registered background task.</summary>
    /// <returns>Returns an ApplicationTriggerResult enumeration that indicates whether the user provided the necessary consent for the operation or the system policies didn't reject the request to trigger a background task.</returns>
    [RemoteAsync]
    [Overload("RequestAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ApplicationTriggerResult> RequestAsync();

    /// <summary>This method attempts to set the trigger and start the registered background task with specified arguments.</summary>
    /// <param name="arguments">The serialized arguments that are passed to the background task.</param>
    /// <returns>Returns an ApplicationTriggerResult enumeration that indicates whether the user provided the necessary consent for the operation or the system policies didn't reject the request to trigger a background task.</returns>
    [Overload("RequestAsyncWithArguments")]
    [MethodImpl]
    public extern IAsyncOperation<ApplicationTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
