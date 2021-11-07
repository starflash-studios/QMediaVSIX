// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SystemCondition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a system condition that must be in effect for a background task to run.</summary>
  [Activatable(typeof (ISystemConditionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class SystemCondition : ISystemCondition, IBackgroundCondition
  {
    /// <summary>Initializes a new instance of a system condition.</summary>
    /// <param name="conditionType">Specifies the condition type.</param>
    [MethodImpl]
    public extern SystemCondition(SystemConditionType conditionType);

    /// <summary>Gets the condition type of a system condition.</summary>
    /// <returns>The condition that must be in effect for the background task to run.</returns>
    public extern SystemConditionType ConditionType { [MethodImpl] get; }
  }
}
