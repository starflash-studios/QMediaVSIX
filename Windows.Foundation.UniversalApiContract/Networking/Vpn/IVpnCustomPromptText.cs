﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptText
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(1003011566, 14914, 18851, 171, 221, 7, 178, 237, 234, 117, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnCustomPromptText))]
  internal interface IVpnCustomPromptText : IVpnCustomPromptElement
  {
    string Text { set; get; }
  }
}