// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRightTappedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1640478651, 40791, 22615, 163, 60, 197, 140, 61, 250, 149, 158)]
  [ExclusiveTo(typeof (RightTappedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IRightTappedEventArgs2
  {
    uint ContactCount { get; }
  }
}
