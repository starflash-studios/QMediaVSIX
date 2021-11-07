// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(580323058, 25229, 20213, 156, 8, 166, 63, 221, 119, 135, 198)]
  [ExclusiveTo(typeof (HolographicCamera))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IHolographicCamera5
  {
    bool IsHardwareContentProtectionSupported { get; }

    bool IsHardwareContentProtectionEnabled { get; set; }
  }
}
