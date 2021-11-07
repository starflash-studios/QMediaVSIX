// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.TrafficCongestion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Specifies the level of traffic congestion along a map route or route leg.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum TrafficCongestion
  {
    /// <summary>The level of traffic congestion is unknown.</summary>
    Unknown,
    /// <summary>The level of traffic congestion is light.</summary>
    Light,
    /// <summary>The level of traffic congestion is mild.</summary>
    Mild,
    /// <summary>The level of traffic congestion is medium.</summary>
    Medium,
    /// <summary>The level of traffic congestion is heavy.</summary>
    Heavy,
  }
}
