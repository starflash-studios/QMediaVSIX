// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerAnnotationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationPeerAnnotation))]
  [Guid(4120658846, 50779, 17357, 144, 9, 3, 252, 2, 51, 99, 167)]
  [WebHostHidden]
  internal interface IAutomationPeerAnnotationFactory
  {
    AutomationPeerAnnotation CreateInstance(AnnotationType type);

    AutomationPeerAnnotation CreateWithPeerParameter(
      AnnotationType type,
      AutomationPeer peer);
  }
}
