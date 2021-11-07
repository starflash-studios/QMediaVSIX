// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayTask))]
  [Guid(1577612360, 4955, 23472, 191, 99, 99, 127, 132, 34, 124, 122)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayTask
  {
    void SetScanout(DisplayScanout scanout);

    void SetWait(DisplayFence readyFence, ulong readyFenceValue);
  }
}
