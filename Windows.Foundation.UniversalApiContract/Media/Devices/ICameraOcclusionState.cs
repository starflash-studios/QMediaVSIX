// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ICameraOcclusionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (CameraOcclusionState))]
  [Guid(1124785848, 26690, 24149, 155, 222, 4, 180, 239, 58, 138, 87)]
  internal interface ICameraOcclusionState
  {
    bool IsOccluded { get; }

    bool IsOcclusionKind(CameraOcclusionKind occlusionKind);
  }
}
