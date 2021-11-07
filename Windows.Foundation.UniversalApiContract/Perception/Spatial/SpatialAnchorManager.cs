// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Static methods for getting the spatial anchor store for the current app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialAnchorManagerStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public static class SpatialAnchorManager
  {
    /// <summary>Retrieves the anchor store for the current app.</summary>
    /// <returns>The anchor store.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialAnchorStore> RequestStoreAsync();
  }
}
