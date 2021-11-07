// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkInputProcessingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies how the InkPresenter object interprets input from it's associated InkCanvas control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InkInputProcessingMode
  {
    /// <summary>All input events are passed to the app and are not processed by the InkPresenter.</summary>
    None,
    /// <summary>Input is treated as ink.</summary>
    Inking,
    /// <summary>Input is treated as erase.</summary>
    Erasing,
  }
}
