﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAppBarAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AppBarAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2204169442, 58262, 17687, 175, 93, 244, 207, 52, 197, 78, 223)]
  internal interface IAppBarAutomationPeerFactory
  {
    AppBarAutomationPeer CreateInstanceWithOwner(
      AppBar owner,
      object baseInterface,
      out object innerInterface);
  }
}