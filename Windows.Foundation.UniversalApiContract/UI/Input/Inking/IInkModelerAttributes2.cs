// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkModelerAttributes2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2261897370, 20216, 24101, 183, 188, 182, 84, 36, 241, 107, 179)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (InkModelerAttributes))]
  internal interface IInkModelerAttributes2
  {
    bool UseVelocityBasedPressure { get; set; }
  }
}
