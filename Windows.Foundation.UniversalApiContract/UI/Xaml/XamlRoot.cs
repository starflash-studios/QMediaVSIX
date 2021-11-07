// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.XamlRoot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a tree of XAML content and information about the context in which it is hosted.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class XamlRoot : IXamlRoot
  {
    /// <summary>Gets the root element of the XAML element tree.</summary>
    /// <returns>The root element of the XAML element tree.</returns>
    public extern UIElement Content { [MethodImpl] get; }

    /// <summary>Gets the width and height of the content area.</summary>
    /// <returns>The width and height of the content area.</returns>
    public extern Size Size { [MethodImpl] get; }

    /// <summary>Gets a value that represents the number of raw (physical) pixels for each view pixel.</summary>
    /// <returns>A value that represents the number of raw (physical) pixels for each view pixel.</returns>
    public extern double RasterizationScale { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the XamlRoot is visible.</summary>
    /// <returns>**true** if the XamlRoot is visible; otherwise, **false**.</returns>
    public extern bool IsHostVisible { [MethodImpl] get; }

    /// <summary>Gets the context identifier for the view.</summary>
    /// <returns>The context identifier for the view.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }

    /// <summary>Occurs when a property of XamlRoot has changed.</summary>
    public extern event TypedEventHandler<XamlRoot, XamlRootChangedEventArgs> Changed;
  }
}
