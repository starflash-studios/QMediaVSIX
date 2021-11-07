// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Provides data for the SpatialLocator.PositionalTrackingDeactivating event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialLocatorPositionalTrackingDeactivatingEventArgs : 
    ISpatialLocatorPositionalTrackingDeactivatingEventArgs
  {
    /// <summary>Gets or sets a value indicating whether to cancel the deactivation of positional tracking due to inactivity.</summary>
    /// <returns>A boolean value indicating whether to cancel the deactivation of positional tracking due to inactivity.</returns>
    public extern bool Canceled { [MethodImpl] get; [MethodImpl] set; }
  }
}
