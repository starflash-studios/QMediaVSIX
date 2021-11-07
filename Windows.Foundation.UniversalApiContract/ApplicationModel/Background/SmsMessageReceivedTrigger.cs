// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SmsMessageReceivedTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Sms;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that is raised when an SMS message has arrived.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISmsMessageReceivedTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsMessageReceivedTrigger : IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of an SMS message received trigger.</summary>
    /// <param name="filterRules">Filter rules to be applied to incoming SMS messages. Only messages that pass through the filter rules raise the trigger.</param>
    [MethodImpl]
    public extern SmsMessageReceivedTrigger(SmsFilterRules filterRules);
  }
}
