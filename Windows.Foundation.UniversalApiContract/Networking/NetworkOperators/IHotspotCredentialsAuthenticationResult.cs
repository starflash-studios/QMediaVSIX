﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IHotspotCredentialsAuthenticationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HotspotCredentialsAuthenticationResult))]
  [Guid(3881224081, 4101, 19941, 131, 199, 222, 97, 216, 136, 49, 208)]
  internal interface IHotspotCredentialsAuthenticationResult
  {
    bool HasNetworkErrorOccurred { get; }

    HotspotAuthenticationResponseCode ResponseCode { get; }

    Uri LogoffUrl { get; }

    XmlDocument AuthenticationReplyXml { get; }
  }
}