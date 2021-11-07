// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Resources.CustomXamlResourceLoader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Resources
{
  /// <summary>Enables loading of custom resource dictionaries as sources. Override GetResource to provide the logic that a XAML parser can use to look up the necessary resources at load time.</summary>
  [Static(typeof (ICustomXamlResourceLoaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (ICustomXamlResourceLoaderFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CustomXamlResourceLoader : 
    ICustomXamlResourceLoader,
    ICustomXamlResourceLoaderOverrides
  {
    /// <summary>Initializes a new instance of the CustomXamlResourceLoader class.</summary>
    [MethodImpl]
    public extern CustomXamlResourceLoader();

    [MethodImpl]
    extern object ICustomXamlResourceLoaderOverrides.GetResource(
      string resourceId,
      string objectType,
      string propertyName,
      string propertyType);

    /// <summary>Returns the active CustomXamlResourceLoader instance.</summary>
    /// <returns>The active CustomXamlResourceLoader instance.</returns>
    public static extern CustomXamlResourceLoader Current { [MethodImpl] get; [MethodImpl] set; }
  }
}
