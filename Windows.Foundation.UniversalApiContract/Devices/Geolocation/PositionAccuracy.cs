// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.PositionAccuracy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Indicates the requested accuracy level for the location data that the application uses.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PositionAccuracy
  {
    /// <summary>Optimize for power, performance, and other cost considerations.</summary>
    Default,
    /// <summary>Deliver the most accurate report possible. This includes using services that might charge money, or consuming higher levels of battery power or connection bandwidth. An accuracy level of **High** may degrade system performance and should be used only when necessary.</summary>
    High,
  }
}
