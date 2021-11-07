﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.PositionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Provides data for the PositionChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PositionChangedEventArgs : IPositionChangedEventArgs
  {
    /// <summary>The location data associated with the PositionChanged event.</summary>
    /// <returns>A Geoposition object containing geographic location data.</returns>
    public extern Geoposition Position { [MethodImpl] get; }
  }
}