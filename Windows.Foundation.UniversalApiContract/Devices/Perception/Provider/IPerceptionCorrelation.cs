// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionCorrelation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception.Provider
{
  [ExclusiveTo(typeof (PerceptionCorrelation))]
  [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(3021150850, 57333, 16455, 138, 25, 59, 77, 128, 95, 113, 118)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionCorrelation
  {
    string TargetId { [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    Vector3 Position { [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    Quaternion Orientation { [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
