// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementFactoryRecycleArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the optional arguments to use when calling an implementation of the IElementFactory 's RecycleElement method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IElementFactoryRecycleArgsFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class ElementFactoryRecycleArgs : IElementFactoryRecycleArgs
  {
    /// <summary>Initializes a new instance of the ElementFactoryRecycleArgs class.</summary>
    [MethodImpl]
    public extern ElementFactoryRecycleArgs();

    /// <summary>Gets or sets the UIElement object to recycle when calling RecycleElement.</summary>
    /// <returns>The UIElement object to recycle.</returns>
    public extern UIElement Element { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to the current parent UIElement of the element being recycled.</summary>
    /// <returns>The parent UIElement object or **null**.  By default, it is **null**.</returns>
    public extern UIElement Parent { [MethodImpl] get; [MethodImpl] set; }
  }
}
