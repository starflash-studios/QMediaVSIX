// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.DatePickerAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes DatePicker types to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IDatePickerAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class DatePickerAutomationPeer : FrameworkElementAutomationPeer, IDatePickerAutomationPeer
  {
    /// <summary>Initializes a new instance of the DatePickerAutomationPeer class.</summary>
    /// <param name="owner">The DatePicker to create the peer for.</param>
    [MethodImpl]
    public extern DatePickerAutomationPeer(DatePicker owner);
  }
}
