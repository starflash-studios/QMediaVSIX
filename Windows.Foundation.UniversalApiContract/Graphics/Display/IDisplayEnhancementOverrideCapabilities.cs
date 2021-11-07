// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayEnhancementOverrideCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1164992734, 61018, 18359, 153, 24, 30, 81, 232, 18, 204, 200)]
  [ExclusiveTo(typeof (DisplayEnhancementOverrideCapabilities))]
  internal interface IDisplayEnhancementOverrideCapabilities
  {
    bool IsBrightnessControlSupported { get; }

    bool IsBrightnessNitsControlSupported { get; }

    IVectorView<NitRange> GetSupportedNitRanges();
  }
}
