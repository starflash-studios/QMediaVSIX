// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IUnifiedPosErrorDataFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1268262225, 8190, 17691, 163, 104, 99, 224, 206, 70, 95, 90)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (UnifiedPosErrorData))]
  internal interface IUnifiedPosErrorDataFactory
  {
    UnifiedPosErrorData CreateInstance(
      string message,
      UnifiedPosErrorSeverity severity,
      UnifiedPosErrorReason reason,
      uint extendedReason);
  }
}
