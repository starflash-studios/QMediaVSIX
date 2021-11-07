// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityConnectedStandbyAction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Indicates whether an app that uses the socket brokering service can receive packets when the system goes to connected stand by.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketActivityConnectedStandbyAction
  {
    /// <summary>The app should not receive packets when the system goes to stand by.</summary>
    DoNotWake,
    /// <summary>The app can receive packets even when the system goes to stand by.</summary>
    Wake,
  }
}
