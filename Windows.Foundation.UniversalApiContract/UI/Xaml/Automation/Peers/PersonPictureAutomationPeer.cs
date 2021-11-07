// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.PersonPictureAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes **PersonPicture ** types to Microsoft UI Automation.</summary>
  [Composable(typeof (IPersonPictureAutomationPeerFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class PersonPictureAutomationPeer : 
    FrameworkElementAutomationPeer,
    IPersonPictureAutomationPeer
  {
    /// <summary>Initializes a new instance of the **PersonPictureAutomationPeer** class.</summary>
    /// <param name="owner">The **PersonPicture ** control instance to create the peer for.</param>
    [MethodImpl]
    public extern PersonPictureAutomationPeer(PersonPicture owner);
  }
}
