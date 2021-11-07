// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Represents any grouped items within a view.</summary>
  [Guid(2114042328, 55221, 18614, 179, 28, 91, 181, 189, 245, 240, 155)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICollectionViewGroup
  {
    /// <summary>Gets or sets the grouping context used for grouping the data, which sets the data context for the default HeaderTemplate.</summary>
    /// <returns>The grouping context used for grouping the data.</returns>
    object Group { get; }

    /// <summary>Gets the collection of grouped items that this ICollectionViewGroup implementation represents.</summary>
    /// <returns>A collection of items for the group.</returns>
    IObservableVector<object> GroupItems { get; }
  }
}
