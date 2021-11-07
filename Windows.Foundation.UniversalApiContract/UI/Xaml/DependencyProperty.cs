// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyProperty
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a dependency property that is registered with the dependency property system. Dependency properties provide support for value expressions, data binding, animation, and property change notification. For more info on how DependencyProperty values serve as identifiers for dependency properties, see Dependency properties overview.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDependencyPropertyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DependencyProperty : IDependencyProperty
  {
    [MethodImpl]
    public extern PropertyMetadata GetMetadata(TypeName forType);

    /// <summary>Specifies a static value that is used by the property system rather than **null** to indicate that the property exists, but does not have its value set by the property system or by any app code.</summary>
    /// <returns>The sentinel value for an unset value.</returns>
    public static extern object UnsetValue { [MethodImpl] get; }

    [MethodImpl]
    public static extern DependencyProperty Register(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata typeMetadata);

    [MethodImpl]
    public static extern DependencyProperty RegisterAttached(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata defaultMetadata);
  }
}
