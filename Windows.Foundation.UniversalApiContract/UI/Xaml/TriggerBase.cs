// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TriggerBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Serves as the base class for EventTrigger. Not commonly used. See Remarks.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ITriggerBaseFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class TriggerBase : DependencyObject, ITriggerBase
  {
  }
}
