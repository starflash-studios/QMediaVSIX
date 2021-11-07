// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntityRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Event data for spatial entity removed events.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SpatialEntityRemovedEventArgs : ISpatialEntityRemovedEventArgs
  {
    /// <summary>Gets the spatial entity that was removed.</summary>
    /// <returns>The removed entity.</returns>
    public extern SpatialEntity Entity { [MethodImpl] get; }
  }
}
