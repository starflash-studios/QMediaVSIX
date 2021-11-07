// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a background task to register with the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackgroundTaskBuilder : 
    IBackgroundTaskBuilder,
    IBackgroundTaskBuilder2,
    IBackgroundTaskBuilder3,
    IBackgroundTaskBuilder4,
    IBackgroundTaskBuilder5
  {
    /// <summary>Creates an instance of the BackgroundTaskBuilder class.</summary>
    [MethodImpl]
    public extern BackgroundTaskBuilder();

    /// <summary>Gets or sets the class that performs the work of a background task.</summary>
    /// <returns>The name of an application-defined class that performs the work of a background task.</returns>
    public extern string TaskEntryPoint { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Sets the event trigger for a background task.</summary>
    /// <param name="trigger">An instance of an event trigger object such as a SystemTrigger, TimeTrigger, or NetworkOperatorNotificationTrigger.</param>
    [MethodImpl]
    public extern void SetTrigger(IBackgroundTrigger trigger);

    /// <summary>Adds a condition to a background task.</summary>
    /// <param name="condition">An instance of a SystemCondition object.</param>
    [MethodImpl]
    public extern void AddCondition(IBackgroundCondition condition);

    /// <summary>Gets or sets the name of a background task.</summary>
    /// <returns>A description of the background task.</returns>
    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Registers a background task with the system.</summary>
    /// <returns>An instance of a BackgroundTaskRegistration object.</returns>
    [MethodImpl]
    public extern BackgroundTaskRegistration Register();

    /// <summary>Indicates whether the background task will be canceled if at least one of its required conditions is no longer met.</summary>
    /// <returns>Whether or not the background task will be canceled if at least one of its required conditions is no longer met.</returns>
    public extern bool CancelOnConditionLoss { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates whether to keep the network up while running the background task.</summary>
    /// <returns>`True`: ensure that the network is up while running the background task. `False`, otherwise.</returns>
    public extern bool IsNetworkRequested { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets and sets the group identifier.</summary>
    /// <returns>The group identifier.</returns>
    public extern BackgroundTaskRegistrationGroup TaskGroup { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>
    /// </summary>
    /// <param name="TaskEntryPoint">
    /// </param>
    [MethodImpl]
    public extern void SetTaskEntryPointClsid(Guid TaskEntryPoint);
  }
}
