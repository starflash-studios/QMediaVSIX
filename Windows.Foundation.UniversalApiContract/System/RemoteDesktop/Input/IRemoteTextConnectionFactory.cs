// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.Input.IRemoteTextConnectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop.Input
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2296411586, 3246, 22892, 133, 15, 120, 211, 69, 205, 114, 139)]
  [ExclusiveTo(typeof (RemoteTextConnection))]
  internal interface IRemoteTextConnectionFactory
  {
    RemoteTextConnection CreateInstance(
      Guid connectionId,
      RemoteTextConnectionDataHandler pduForwarder);
  }
}
