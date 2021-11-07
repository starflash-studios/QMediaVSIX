// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.Input.IRemoteTextConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop.Input
{
  [Guid(1316728874, 6206, 24166, 181, 228, 62, 110, 92, 87, 12, 241)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (RemoteTextConnection))]
  internal interface IRemoteTextConnection
  {
    bool IsEnabled { get; set; }

    void RegisterThread(uint threadId);

    void UnregisterThread(uint threadId);

    void ReportDataReceived(byte[] pduData);
  }
}
