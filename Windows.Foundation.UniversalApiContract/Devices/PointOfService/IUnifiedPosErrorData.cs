// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IUnifiedPosErrorData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (UnifiedPosErrorData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(731483194, 21852, 18569, 142, 216, 197, 153, 187, 58, 113, 42)]
  internal interface IUnifiedPosErrorData
  {
    string Message { get; }

    UnifiedPosErrorSeverity Severity { get; }

    UnifiedPosErrorReason Reason { get; }

    uint ExtendedReason { get; }
  }
}
