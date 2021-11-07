// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreWetStrokeDisposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  /// <summary>Defines constants that specify the pre-rendered state (Disposition ) of the "wet" ink stroke.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum CoreWetStrokeDisposition
  {
    /// <summary>Ink stroke is underway.</summary>
    Inking,
    /// <summary>Ink stroke is to be completed.</summary>
    Completed,
    /// <summary>Ink stroke is to be canceled.</summary>
    Canceled,
  }
}
