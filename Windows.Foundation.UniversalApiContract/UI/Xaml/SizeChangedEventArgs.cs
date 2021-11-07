// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.SizeChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data related to the FrameworkElement.SizeChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SizeChangedEventArgs : RoutedEventArgs, ISizeChangedEventArgs
  {
    /// <summary>Gets the previous size of the object reporting the size change.</summary>
    /// <returns>The previous size.</returns>
    public extern Size PreviousSize { [MethodImpl] get; }

    /// <summary>Gets the new size of the object reporting the size change.</summary>
    /// <returns>The new size. The Size structure contains the new height and width.</returns>
    public extern Size NewSize { [MethodImpl] get; }
  }
}
