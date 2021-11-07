// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPenDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (PenDevice))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(830828218, 42808, 23180, 184, 246, 249, 126, 246, 141, 24, 239)]
  internal interface IPenDevice
  {
    Guid PenId { get; }
  }
}
