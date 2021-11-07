// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [Guid(728470598, 47513, 21813, 157, 105, 83, 240, 146, 199, 128, 161)]
  [ExclusiveTo(typeof (DisplayManager))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayManagerStatics
  {
    DisplayManager Create(DisplayManagerOptions options);
  }
}
