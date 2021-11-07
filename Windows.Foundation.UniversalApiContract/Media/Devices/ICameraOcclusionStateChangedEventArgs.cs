// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ICameraOcclusionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2232604744, 49374, 22474, 161, 202, 251, 44, 61, 35, 223, 85)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (CameraOcclusionStateChangedEventArgs))]
  internal interface ICameraOcclusionStateChangedEventArgs
  {
    CameraOcclusionState State { get; }
  }
}
