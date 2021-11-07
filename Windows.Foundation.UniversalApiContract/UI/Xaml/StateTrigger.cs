// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.StateTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a trigger that applies visual states conditionally.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStateTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class StateTrigger : StateTriggerBase, IStateTrigger
  {
    /// <summary>Initializes a new instance of the StateTrigger class.</summary>
    [MethodImpl]
    public extern StateTrigger();

    /// <summary>Gets or sets a value that indicates whether the trigger should be applied.</summary>
    /// <returns>**true** if the system should apply the trigger; otherwise, **false**.</returns>
    public extern bool IsActive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsActive  dependency property.</summary>
    /// <returns>The identifier for the IsActive  dependency property.</returns>
    public static extern DependencyProperty IsActiveProperty { [MethodImpl] get; }
  }
}
