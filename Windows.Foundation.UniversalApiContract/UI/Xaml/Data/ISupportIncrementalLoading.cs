// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ISupportIncrementalLoading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Specifies a calling contract for collection views that support incremental loading.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2136926610, 30356, 20076, 165, 27, 227, 75, 244, 61, 231, 67)]
  public interface ISupportIncrementalLoading
  {
    /// <summary>Initializes incremental loading from the view.</summary>
    /// <param name="count">The number of items to load.</param>
    /// <returns>The wrapped results of the load operation.</returns>
    [RemoteAsync]
    IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(
      uint count);

    /// <summary>Gets a sentinel value that supports incremental loading implementations.</summary>
    /// <returns>**true** if additional unloaded items remain in the view; otherwise, **false**.</returns>
    bool HasMoreItems { get; }
  }
}
