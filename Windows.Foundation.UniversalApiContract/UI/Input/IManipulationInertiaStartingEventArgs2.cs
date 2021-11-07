// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationInertiaStartingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (ManipulationInertiaStartingEventArgs))]
  [Guid(3260287416, 63994, 23109, 189, 151, 220, 187, 178, 32, 24, 96)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IManipulationInertiaStartingEventArgs2
  {
    uint ContactCount { get; }
  }
}
