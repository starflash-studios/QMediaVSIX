// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ResourceDictionary
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines a repository for XAML resources, such as styles, that your app uses. You define the resources in XAML and can then retrieve them in XAML using the {StaticResource} markup extension and {ThemeResource} markup extension s. You can also access resources with code, but that is less common.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IResourceDictionaryFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class ResourceDictionary : 
    DependencyObject,
    IResourceDictionary,
    IMap<object, object>,
    IIterable<IKeyValuePair<object, object>>
  {
    /// <summary>Initializes a new instance of the ResourceDictionary class.</summary>
    [MethodImpl]
    public extern ResourceDictionary();

    /// <summary>Gets or sets a Uniform Resource Identifier (URI) that provides the source location of a merged resource dictionary.</summary>
    /// <returns>A Uniform Resource Identifier (URI) that provides the source location of a merged resource dictionary. This is typically a path that references a XAML resource within the app, or a reference to a loose XAML file.</returns>
    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection of the ResourceDictionary dictionaries that constitute the various resource dictionaries in the merged dictionaries.</summary>
    /// <returns>A list collection of the ResourceDictionary dictionaries that constitute the various resource dictionaries in the merged dictionaries.</returns>
    public extern IVector<ResourceDictionary> MergedDictionaries { [MethodImpl] get; }

    /// <summary>Gets a collection of merged resource dictionaries that are specifically keyed and composed to address theme scenarios, for example supplying theme values for "HighContrast".</summary>
    /// <returns>A dictionary of ResourceDictionary theme dictionaries. Each must be keyed with **x:Key**.</returns>
    public extern IMap<object, object> ThemeDictionaries { [MethodImpl] get; }

    [MethodImpl]
    public extern object Lookup(object key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(object key);

    [MethodImpl]
    public extern IMapView<object, object> GetView();

    [MethodImpl]
    public extern bool Insert(object key, object value);

    [MethodImpl]
    public extern void Remove(object key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<object, object>> First();
  }
}
