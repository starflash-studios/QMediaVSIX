// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindowFlowDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies the flow order for text in a window.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreWindowFlowDirection
  {
    /// <summary>Text is flowed from left to right.</summary>
    LeftToRight,
    /// <summary>Text is flowed from right to left. (For example, this can be used with Arabic script or other RTL languages.)</summary>
    RightToLeft,
  }
}
