﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.CameraOcclusionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class CameraOcclusionInfo : ICameraOcclusionInfo
  {
    [MethodImpl]
    public extern CameraOcclusionState GetState();

    [MethodImpl]
    public extern bool IsOcclusionKindSupported(CameraOcclusionKind occlusionKind);

    public extern event TypedEventHandler<CameraOcclusionInfo, CameraOcclusionStateChangedEventArgs> StateChanged;
  }
}