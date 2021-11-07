// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.CacheMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents cached content modes for graphics acceleration features.</summary>
  [Composable(typeof (ICacheModeFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class CacheMode : DependencyObject, ICacheMode
  {
    /// <summary>Provides base class initialization behavior for CacheMode derived classes.</summary>
    [MethodImpl]
    protected extern CacheMode();
  }
}
