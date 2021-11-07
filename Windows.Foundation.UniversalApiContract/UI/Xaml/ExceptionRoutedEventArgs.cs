// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ExceptionRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides event data for exceptions that are raised as events by asynchronous operations, such as ImageFailed.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IExceptionRoutedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public class ExceptionRoutedEventArgs : RoutedEventArgs, IExceptionRoutedEventArgs
  {
    /// <summary>Gets the message component of the exception, as a string.</summary>
    /// <returns>The message component of the exception.</returns>
    public extern string ErrorMessage { [MethodImpl] get; }
  }
}
