// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerAnnotationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(2282334333, 2482, 19781, 183, 139, 29, 59, 59, 9, 246, 97)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationPeerAnnotation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAutomationPeerAnnotationStatics
  {
    DependencyProperty TypeProperty { get; }

    DependencyProperty PeerProperty { get; }
  }
}
