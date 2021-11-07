// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementFactoryGetArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the optional arguments to use when calling an implementation of the IElementFactory 's GetElement method.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IElementFactoryGetArgsFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  public class ElementFactoryGetArgs : IElementFactoryGetArgs
  {
    /// <summary>Initializes a new instance of the ElementFactoryGetArgs class.</summary>
    [MethodImpl]
    public extern ElementFactoryGetArgs();

    /// <summary>Gets or sets the data item for which an appropriate element tree should be realized when calling GetElement.</summary>
    /// <returns>A reference to the data item for which a UIElement should be realized.</returns>
    public extern object Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the UIElement that is expected to be the parent of the realized element from GetElement.</summary>
    /// <returns>The UIElement object expected to be the parent of the realized UIElement or **null**.  By default, it is **null**.</returns>
    public extern UIElement Parent { [MethodImpl] get; [MethodImpl] set; }
  }
}
