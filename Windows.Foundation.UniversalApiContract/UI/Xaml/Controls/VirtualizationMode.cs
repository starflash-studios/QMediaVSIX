// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VirtualizationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how VirtualizingStackPanel manages item containers for its child items.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VirtualizationMode
  {
    /// <summary>Create and discard the item containers.</summary>
    Standard,
    /// <summary>Reuse the item containers.</summary>
    Recycling,
  }
}
