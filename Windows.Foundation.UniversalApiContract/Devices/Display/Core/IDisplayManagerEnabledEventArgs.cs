// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayManagerEnabledEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayManagerEnabledEventArgs))]
  [Guid(4040114031, 17146, 22946, 178, 151, 38, 225, 113, 61, 232, 72)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayManagerEnabledEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
