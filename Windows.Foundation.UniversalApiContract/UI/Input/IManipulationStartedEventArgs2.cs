// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationStartedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(765713230, 58755, 20565, 175, 170, 22, 253, 152, 101, 49, 166)]
  [ExclusiveTo(typeof (ManipulationStartedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IManipulationStartedEventArgs2
  {
    uint ContactCount { get; }
  }
}
