// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IHoldingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (HoldingEventArgs))]
  [Guid(337488362, 19577, 22132, 175, 234, 73, 63, 222, 185, 31, 25)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IHoldingEventArgs2
  {
    uint ContactCount { get; }

    uint CurrentContactCount { get; }
  }
}
