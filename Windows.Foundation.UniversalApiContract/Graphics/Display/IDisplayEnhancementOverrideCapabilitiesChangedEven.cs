// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayEnhancementOverrideCapabilitiesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3680626276, 5626, 18906, 139, 119, 7, 219, 210, 175, 88, 93)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (DisplayEnhancementOverrideCapabilitiesChangedEventArgs))]
  internal interface IDisplayEnhancementOverrideCapabilitiesChangedEventArgs
  {
    DisplayEnhancementOverrideCapabilities Capabilities { get; }
  }
}
