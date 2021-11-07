// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.Input.RemoteTextConnectionDataHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop.Input
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(161479624, 35787, 16821, 176, 86, 87, 231, 112, 33, 191, 27)]
  public delegate bool RemoteTextConnectionDataHandler(byte[] pduData);
}
