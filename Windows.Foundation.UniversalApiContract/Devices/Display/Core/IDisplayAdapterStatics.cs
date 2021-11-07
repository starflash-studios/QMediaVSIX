// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayAdapterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayAdapter))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(497827034, 18463, 21609, 132, 112, 130, 196, 186, 104, 10, 40)]
  internal interface IDisplayAdapterStatics
  {
    DisplayAdapter FromId(DisplayAdapterId id);
  }
}
