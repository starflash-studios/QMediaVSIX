// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayManagerChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DisplayManagerChangedEventArgs))]
  [Guid(1790943877, 27850, 22321, 188, 220, 66, 229, 210, 245, 197, 15)]
  internal interface IDisplayManagerChangedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
