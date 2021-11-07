// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationCompletedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(4039171303, 12457, 23446, 136, 111, 101, 96, 168, 94, 71, 87)]
  [ExclusiveTo(typeof (ManipulationCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IManipulationCompletedEventArgs2
  {
    uint ContactCount { get; }

    uint CurrentContactCount { get; }
  }
}
