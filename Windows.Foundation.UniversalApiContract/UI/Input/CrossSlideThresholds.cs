// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.CrossSlideThresholds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains the distance thresholds for a CrossSliding interaction.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct CrossSlideThresholds
  {
    /// <summary>The distance, in device-independent pixel (DIP), from the initial point of contact until the selection action is initiated.</summary>
    public float SelectionStart;
    /// <summary>The distance, in device-independent pixel (DIP), from the initial point of contact until the speed bump is initiated.</summary>
    public float SpeedBumpStart;
    /// <summary>The distance, in device-independent pixel (DIP), from the initial point of contact until the end of the speed bump.</summary>
    public float SpeedBumpEnd;
    /// <summary>The distance, in device-independent pixel (DIP), from the initial point of contact until the rearrange action is initiated.</summary>
    public float RearrangeStart;
  }
}
