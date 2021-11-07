// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IPersonPictureAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(2841583469, 9508, 17572, 151, 253, 17, 129, 19, 1, 0, 173)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PersonPictureAutomationPeer))]
  internal interface IPersonPictureAutomationPeerFactory
  {
    PersonPictureAutomationPeer CreateInstanceWithOwner(
      PersonPicture owner,
      object baseInterface,
      out object innerInterface);
  }
}
