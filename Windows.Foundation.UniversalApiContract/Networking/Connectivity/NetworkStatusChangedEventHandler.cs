// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkStatusChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents the method that handles network status change notifications. This method is called when any properties exposed by the NetworkInformation object changes while the app is active.</summary>
  /// <param name="sender">A Object that raised the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1908020287, 22926, 18896, 132, 235, 143, 235, 174, 220, 193, 149)]
  public delegate void NetworkStatusChangedEventHandler(object sender);
}
