// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitButtonAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SplitButtonAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(3594134836, 30684, 21345, 132, 34, 74, 216, 117, 15, 69, 244)]
  internal interface ISplitButtonAutomationPeerFactory
  {
    SplitButtonAutomationPeer CreateInstance(
      SplitButton owner,
      object baseInterface,
      out object innerInterface);
  }
}
