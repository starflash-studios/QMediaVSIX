// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides a XAML processor engine for parsing XAML and creating corresponding object trees.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IXamlReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class XamlReader : IXamlReader
  {
    /// <summary>Parses a well-formed XAML fragment and creates a corresponding object tree, and returns the root of the object tree.</summary>
    /// <param name="xaml">A string that contains a valid XAML fragment.</param>
    /// <returns>The root object of the created object tree.</returns>
    [MethodImpl]
    public static extern object Load(string xaml);

    /// <summary>Parses a well-formed XAML fragment creates a corresponding object tree, and returns the root of the object tree. Also performs load-time validation of any linked templates.</summary>
    /// <param name="xaml">A string that contains a valid XAML fragment.</param>
    /// <returns>The root object of the created object tree.</returns>
    [MethodImpl]
    public static extern object LoadWithInitialTemplateValidation(string xaml);
  }
}
