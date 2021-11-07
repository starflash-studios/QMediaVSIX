// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ICameraOcclusionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2943109840, 43085, 23990, 190, 88, 165, 218, 33, 207, 224, 17)]
  [ExclusiveTo(typeof (CameraOcclusionInfo))]
  internal interface ICameraOcclusionInfo
  {
    CameraOcclusionState GetState();

    bool IsOcclusionKindSupported(CameraOcclusionKind occlusionKind);

    event TypedEventHandler<CameraOcclusionInfo, CameraOcclusionStateChangedEventArgs> StateChanged;
  }
}
