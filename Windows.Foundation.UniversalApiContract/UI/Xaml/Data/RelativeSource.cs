// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.RelativeSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Implements a markup extension that describes the location of the binding source relative to the position of the binding target.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IRelativeSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class RelativeSource : DependencyObject, IRelativeSource
  {
    /// <summary>Initializes a new instance of the RelativeSource class by using default relative source mode.</summary>
    [MethodImpl]
    public extern RelativeSource();

    /// <summary>Gets or sets a value that describes the location of the binding source relative to the position of the binding target.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern RelativeSourceMode Mode { [MethodImpl] get; [MethodImpl] set; }
  }
}
