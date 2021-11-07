// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.DeviceDepartedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Describes the method that handles the DeviceDeparted event.</summary>
  /// <param name="sender">The proximity device that raised the DeviceDeparted event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4020886121, 63202, 18889, 164, 158, 142, 15, 197, 143, 185, 17)]
  public delegate void DeviceDepartedEventHandler(ProximityDevice sender);
}
