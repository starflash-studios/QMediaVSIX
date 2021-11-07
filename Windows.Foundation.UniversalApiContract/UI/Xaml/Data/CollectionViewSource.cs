// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.CollectionViewSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides a data source that adds grouping and current-item support to collection classes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICollectionViewSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class CollectionViewSource : DependencyObject, ICollectionViewSource
  {
    /// <summary>Initializes a new instance of the CollectionViewSource class.</summary>
    [MethodImpl]
    public extern CollectionViewSource();

    /// <summary>Gets or sets the collection object from which to create this view.</summary>
    /// <returns>The collection to create the view from.</returns>
    public extern object Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the view object that is currently associated with this instance of CollectionViewSource.</summary>
    /// <returns>The view object that is currently associated with this instance of CollectionViewSource.</returns>
    public extern ICollectionView View { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether source data is grouped.</summary>
    /// <returns>**true** if data is grouped. **false** if data is not grouped.</returns>
    public extern bool IsSourceGrouped { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the property path to follow from the top level item to find groups within the CollectionViewSource.</summary>
    /// <returns>The property path to follow from the top level item to find groups. The default is a PropertyPath created from an empty string. This path implies that the object itself is the collection.</returns>
    public extern PropertyPath ItemsPath { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Source dependency property.</summary>
    /// <returns>The identifier for the Source dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the View dependency property.</summary>
    /// <returns>The identifier for the View dependency property.</returns>
    public static extern DependencyProperty ViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSourceGrouped dependency property.</summary>
    /// <returns>The identifier for the IsSourceGrouped dependency property.</returns>
    public static extern DependencyProperty IsSourceGroupedProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemsPath dependency property.</summary>
    /// <returns>The identifier for the ItemsPath dependency property.</returns>
    public static extern DependencyProperty ItemsPathProperty { [MethodImpl] get; }
  }
}
