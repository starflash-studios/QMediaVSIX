// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IBrightnessOverrideSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3507661610, 30212, 19898, 188, 248, 75, 111, 73, 80, 44, 176)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BrightnessOverrideSettings))]
  internal interface IBrightnessOverrideSettings
  {
    double DesiredLevel { get; }

    float DesiredNits { get; }
  }
}
