// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplaySource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplaySource))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1910606162, 45857, 23284, 191, 232, 3, 251, 234, 49, 228, 13)]
  internal interface IDisplaySource2
  {
    DisplaySourceStatus Status { get; }

    event TypedEventHandler<DisplaySource, object> StatusChanged;
  }
}
