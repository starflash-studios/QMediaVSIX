// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayTaskResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayTaskResult))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1874623847, 63921, 21984, 157, 136, 211, 165, 25, 122, 63, 89)]
  internal interface IDisplayTaskResult
  {
    DisplayPresentStatus PresentStatus { get; }

    ulong PresentId { get; }

    DisplaySourceStatus SourceStatus { get; }
  }
}
