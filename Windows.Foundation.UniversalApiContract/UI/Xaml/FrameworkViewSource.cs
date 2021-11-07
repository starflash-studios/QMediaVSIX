// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkViewSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Creates views, specifically FrameworkView instances. This is infrastructure and does not need to be accessed in most app scenarios.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FrameworkViewSource : IFrameworkViewSource, global::Windows.ApplicationModel.Core.IFrameworkViewSource
  {
    /// <summary>Initializes a new instance of the FrameworkViewSource class.</summary>
    [MethodImpl]
    public extern FrameworkViewSource();

    /// <summary>Creates a FrameworkView.</summary>
    /// <returns>The created FrameworkView.</returns>
    [MethodImpl]
    public extern global::Windows.ApplicationModel.Core.IFrameworkView CreateView();
  }
}
