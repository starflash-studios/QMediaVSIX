// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayManagerPathsFailedOrInvalidatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(61232729, 7660, 23573, 178, 162, 143, 233, 18, 152, 105, 254)]
  [ExclusiveTo(typeof (DisplayManagerPathsFailedOrInvalidatedEventArgs))]
  internal interface IDisplayManagerPathsFailedOrInvalidatedEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
