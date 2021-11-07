// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMenuBarAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(705251441, 19099, 23051, 159, 218, 123, 195, 174, 149, 124, 83)]
  [ExclusiveTo(typeof (MenuBarAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IMenuBarAutomationPeerFactory
  {
    MenuBarAutomationPeer CreateInstance(
      MenuBar owner,
      object baseInterface,
      out object innerInterface);
  }
}
