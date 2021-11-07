// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.HoldingState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the state of the Holding event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HoldingState
  {
    /// <summary>A single contact has been detected and a time threshold is crossed without the contact being lifted, another contact detected, or another gesture started.</summary>
    Started,
    /// <summary>The single contact is lifted.</summary>
    Completed,
    /// <summary>An additional contact is detected, a subsequent gesture (such as a slide) is detected, or the CompleteGesture method is called.</summary>
    Canceled,
  }
}
