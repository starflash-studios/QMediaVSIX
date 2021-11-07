// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkRecognitionTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Indicates which strokes you want to include in handwriting recognition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InkRecognitionTarget
  {
    /// <summary>All strokes in the stroke collection are passed to the recognizer.</summary>
    All,
    /// <summary>Selected (Selected ) strokes are passed to the recognizer.</summary>
    Selected,
    /// <summary>All strokes added after the last recognition pass (Recognized is false) are passed to the recognizer.This is useful in incremental recognition scenarios, such as direct tracking of ink input (no indirect controls are used to start recognition).</summary>
    Recent,
  }
}
