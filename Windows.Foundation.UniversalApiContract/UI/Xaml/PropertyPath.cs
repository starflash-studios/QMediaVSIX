// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.PropertyPath
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Implements a data structure for describing a property as a path below another property, or below an owning type. Property paths are used in data binding to objects.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPropertyPathFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class PropertyPath : DependencyObject, IPropertyPath
  {
    /// <summary>Initializes a new instance of the PropertyPath class based on a path string.</summary>
    /// <param name="path">The path string to construct with.</param>
    [MethodImpl]
    public extern PropertyPath(string path);

    /// <summary>Gets the path value held by this PropertyPath.</summary>
    /// <returns>The path value held by this PropertyPath.</returns>
    public extern string Path { [MethodImpl] get; }
  }
}
