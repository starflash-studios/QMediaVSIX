// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayStateOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(4239245279, 56359, 22072, 183, 242, 235, 223, 164, 247, 234, 147)]
  [ExclusiveTo(typeof (DisplayStateOperationResult))]
  internal interface IDisplayStateOperationResult
  {
    DisplayStateOperationStatus Status { get; }

    HResult ExtendedErrorCode { get; }
  }
}
