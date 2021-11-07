// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayColorOverrideScenario
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Represents the color scenarios that a ColorOverrideSettings object can request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum DisplayColorOverrideScenario
  {
    /// <summary>Indicates that colorimetrically accurate display color is wanted. In addition to disabling inbox white point adaptation (such as Night Light), color enhancements that deviate from a standardized colorspace, such as contract and saturation adjustments will be disabled on a best effort basis.</summary>
    Accurate,
  }
}
