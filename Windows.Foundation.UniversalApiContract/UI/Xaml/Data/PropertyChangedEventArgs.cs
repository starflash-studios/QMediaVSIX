// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.PropertyChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides data for the PropertyChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IPropertyChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class PropertyChangedEventArgs : IPropertyChangedEventArgs
  {
    /// <summary>Initializes a new instance of the PropertyChangedEventArgs class.</summary>
    /// <param name="name">The short name of the property that changed.</param>
    [MethodImpl]
    public extern PropertyChangedEventArgs(string name);

    /// <summary>Gets the name of the property that changed.</summary>
    /// <returns>The name of the property that changed.</returns>
    public extern string PropertyName { [MethodImpl] get; }
  }
}
