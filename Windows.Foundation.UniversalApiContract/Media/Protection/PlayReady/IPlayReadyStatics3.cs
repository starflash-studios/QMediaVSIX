// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1067663217, 11731, 19437, 174, 73, 247, 20, 142, 99, 231, 16)]
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyStatics3 : IPlayReadyStatics2, IPlayReadyStatics
  {
    Guid SecureStopServiceRequestType { get; }

    bool CheckSupportedHardware(PlayReadyHardwareDRMFeatures hwdrmFeature);
  }
}
