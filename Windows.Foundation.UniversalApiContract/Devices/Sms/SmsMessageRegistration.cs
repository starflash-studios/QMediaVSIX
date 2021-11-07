// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsMessageRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Class used to represent registered message filters.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISmsMessageRegistrationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsMessageRegistration : ISmsMessageRegistration
  {
    /// <summary>Gets an identifier for this registered message filter.</summary>
    /// <returns>The identifier specified at registration.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Unregisters a previously-registered message filter. The filter will no longer be applied to incoming messages.</summary>
    [MethodImpl]
    public extern void Unregister();

    /// <summary>Event signaled when a message has been received that meets the filter criteria set in a registered message filter.</summary>
    public extern event TypedEventHandler<SmsMessageRegistration, SmsMessageReceivedTriggerDetails> MessageReceived;

    /// <summary>Static property that gets a list of currently registered message filters..</summary>
    /// <returns>A list of current registrations.</returns>
    public static extern IVectorView<SmsMessageRegistration> AllRegistrations { [MethodImpl] get; }

    /// <summary>Registers a message filter.</summary>
    /// <param name="id">Identifier used to describe this message filter.</param>
    /// <param name="filterRules">An object that represents the filter rules to be used for this registered message filter.</param>
    /// <returns>On successful completion, the SmsMessageRegistration object that represents this registered message filter.</returns>
    [MethodImpl]
    public static extern SmsMessageRegistration Register(
      string id,
      SmsFilterRules filterRules);
  }
}
