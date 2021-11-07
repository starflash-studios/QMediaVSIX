// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides the ability to create a bitmap from a XAML tree in a background task.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IXamlRenderingBackgroundTaskFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class XamlRenderingBackgroundTask : 
    IXamlRenderingBackgroundTask,
    IXamlRenderingBackgroundTaskOverrides
  {
    /// <summary>Initializes a new instance of the XamlRenderingBackgroundTask class.</summary>
    [MethodImpl]
    protected extern XamlRenderingBackgroundTask();

    [MethodImpl]
    extern void IXamlRenderingBackgroundTaskOverrides.OnRun(
      IBackgroundTaskInstance taskInstance);
  }
}
