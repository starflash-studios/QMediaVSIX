// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntityAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Event data for spatial entity added events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SpatialEntityAddedEventArgs : ISpatialEntityAddedEventArgs
  {
    /// <summary>Gets the spatial entity that was added.</summary>
    /// <returns>The added entity.</returns>
    public extern SpatialEntity Entity { [MethodImpl] get; }
  }
}
