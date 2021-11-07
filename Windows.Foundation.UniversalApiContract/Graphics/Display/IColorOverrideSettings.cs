// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IColorOverrideSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (ColorOverrideSettings))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4226785588, 19073, 19533, 165, 182, 125, 27, 92, 75, 208, 11)]
  internal interface IColorOverrideSettings
  {
    DisplayColorOverrideScenario DesiredDisplayColorOverrideScenario { get; }
  }
}
