﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemDiscoveryTypeFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(1121518623, 61018, 17370, 172, 106, 111, 238, 37, 70, 7, 65)]
  [ExclusiveTo(typeof (RemoteSystemDiscoveryTypeFilter))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemDiscoveryTypeFilter
  {
    RemoteSystemDiscoveryType RemoteSystemDiscoveryType { get; }
  }
}