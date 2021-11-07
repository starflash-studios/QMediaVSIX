// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsFilterRules
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>A collection of SmsFilterRule instances.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISmsFilterRulesFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SmsFilterRules : ISmsFilterRules
  {
    /// <summary>Creates an instance of SmsFilterRules.</summary>
    /// <param name="actionType">An enumeration value that specifies which action type is to be associated with the rules for this instance. Action type determines the order in which rules are evaluated, as well as the action to be taken when a rule is matched.</param>
    [MethodImpl]
    public extern SmsFilterRules(SmsFilterActionType actionType);

    /// <summary>The SmsFilterActionType for this set of filter rules.</summary>
    /// <returns>Specifies when and how the set of rules in this SmsFilterRules collection are to be applied to incoming SMS messages.</returns>
    public extern SmsFilterActionType ActionType { [MethodImpl] get; }

    /// <summary>Gets the list of rules in this SmsFilterRules instance.</summary>
    /// <returns>A list of SMS filter rules.</returns>
    public extern IVector<SmsFilterRule> Rules { [MethodImpl] get; }
  }
}
