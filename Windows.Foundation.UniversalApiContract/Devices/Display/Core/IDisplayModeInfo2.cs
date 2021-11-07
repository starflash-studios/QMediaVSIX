// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayModeInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayModeInfo))]
  [Guid(3362759558, 3547, 21619, 191, 176, 75, 120, 7, 181, 249, 9)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IDisplayModeInfo2
  {
    DisplayPresentationRate PhysicalPresentationRate { get; }
  }
}
