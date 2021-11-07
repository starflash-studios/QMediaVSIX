// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.PreviewPageCountType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  /// <summary>Describes the basis of the page count.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum PreviewPageCountType
  {
    /// <summary>Page count is based on final print job total.</summary>
    Final,
    /// <summary>Page count is based on an intermediate total.</summary>
    Intermediate,
  }
}
