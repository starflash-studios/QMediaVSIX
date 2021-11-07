// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationUpdatedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(4091525482, 13062, 22787, 161, 197, 255, 151, 87, 168, 104, 158)]
  [ExclusiveTo(typeof (ManipulationUpdatedEventArgs))]
  internal interface IManipulationUpdatedEventArgs2
  {
    uint ContactCount { get; }

    uint CurrentContactCount { get; }
  }
}
