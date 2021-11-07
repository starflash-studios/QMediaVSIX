// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IncrementalLoadingTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify list view incremental loading behavior (IncrementalLoadingTrigger property).</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum IncrementalLoadingTrigger
  {
    /// <summary>Incremental loading does not occur.</summary>
    None,
    /// <summary>Uses an "edge" offset for incremental loading visual behavior, and enables the list view to notify the scroll host of incremental load per interaction with other settings (IncrementalLoadingThreshold, DataFetchSize ).</summary>
    Edge,
  }
}
