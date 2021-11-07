﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides access to an instance of a background task.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUIBackgroundTaskInstanceRuntimeClass : 
    IWebUIBackgroundTaskInstance,
    IBackgroundTaskInstance
  {
    /// <summary>Gets or sets the success value for the background task. The success value is what is returned to the foreground instance of your app in the completed event.</summary>
    /// <returns>An app can set this property to **false** to indicate that the background task has failed. Otherwise this property is always **true.**</returns>
    public extern bool Succeeded { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the instance ID of the background task instance.</summary>
    /// <returns>A unique identifier for the background task instance. This identifier is generated by the system when the instance is created.</returns>
    public extern Guid InstanceId { [MethodImpl] get; }

    /// <summary>Gets access to the registered background task for this background task instance.</summary>
    /// <returns>An interface that provides access to the registered background task.</returns>
    public extern BackgroundTaskRegistration Task { [MethodImpl] get; }

    /// <summary>Gets or sets progress status for a background task instance.</summary>
    /// <returns>A value defined by the application to indicate the task's progress.</returns>
    public extern uint Progress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets additional information associated with a background task instance.</summary>
    /// <returns>Represents additional information for the background task. If the background task is triggered by a mobile network operator notification, this property is an instance of a NetworkOperatorNotificationEventDetails class. If the background task is triggered by a system event or time event, this property is not used.</returns>
    public extern object TriggerDetails { [MethodImpl] get; }

    /// <summary>Attaches a cancellation event handler to the background task instance.</summary>
    public extern event BackgroundTaskCanceledEventHandler Canceled;

    /// <summary>Gets the number of times resource management policy caused the background task to be suspended.</summary>
    /// <returns>The number of times the background task has been suspended.</returns>
    public extern uint SuspendedCount { [MethodImpl] get; }

    /// <summary>Informs the system that the background task might continue to perform work after the IBackgroundTask.Run method returns. This method is not applicable to JavaScript background tasks.</summary>
    /// <returns>A background task deferral.</returns>
    [MethodImpl]
    public extern BackgroundTaskDeferral GetDeferral();
  }
}