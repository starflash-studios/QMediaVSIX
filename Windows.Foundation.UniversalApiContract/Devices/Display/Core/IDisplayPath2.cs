// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayPath2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [Guid(4079245765, 59796, 22283, 158, 200, 239, 66, 195, 90, 133, 71)]
  [ExclusiveTo(typeof (DisplayPath))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IDisplayPath2
  {
    IReference<DisplayPresentationRate> PhysicalPresentationRate { get; set; }
  }
}
