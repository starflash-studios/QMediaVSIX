// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IKnownPerceptionFrameKindStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(988172758, 38505, 16646, 159, 174, 72, 53, 193, 185, 97, 4)]
  [ExclusiveTo(typeof (KnownPerceptionFrameKind))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKnownPerceptionFrameKindStatics
  {
    string Color { [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string Depth { [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string Infrared { [Deprecated("KnownPerceptionFrameKind may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
