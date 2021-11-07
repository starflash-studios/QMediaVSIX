// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayTaskPool2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [Guid(1186494902, 23831, 22869, 168, 114, 235, 56, 0, 61, 181, 134)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (DisplayTaskPool))]
  internal interface IDisplayTaskPool2
  {
    DisplayTaskResult TryExecuteTask(DisplayTask task);
  }
}
