// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.Input.RemoteTextConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop.Input
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Activatable(typeof (IRemoteTextConnectionFactory), 851968, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteTextConnection : IRemoteTextConnection, IClosable
  {
    [MethodImpl]
    public extern RemoteTextConnection(
      Guid connectionId,
      RemoteTextConnectionDataHandler pduForwarder);

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void RegisterThread(uint threadId);

    [MethodImpl]
    public extern void UnregisterThread(uint threadId);

    [MethodImpl]
    public extern void ReportDataReceived(byte[] pduData);

    [MethodImpl]
    public extern void Close();
  }
}
