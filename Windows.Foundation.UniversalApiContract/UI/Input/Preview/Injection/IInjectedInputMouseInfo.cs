// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputMouseInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(2532666987, 58490, 23796, 65, 141, 138, 95, 185, 103, 12, 125)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InjectedInputMouseInfo))]
  internal interface IInjectedInputMouseInfo
  {
    InjectedInputMouseOptions MouseOptions { get; set; }

    uint MouseData { get; set; }

    int DeltaY { get; set; }

    int DeltaX { get; set; }

    uint TimeOffsetInMilliseconds { get; set; }
  }
}
