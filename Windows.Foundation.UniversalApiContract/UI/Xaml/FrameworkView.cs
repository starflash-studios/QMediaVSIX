// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the UI window of an application.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FrameworkView : IFrameworkView, global::Windows.ApplicationModel.Core.IFrameworkView
  {
    /// <summary>Initializes a new instance of the FrameworkView class.</summary>
    [MethodImpl]
    public extern FrameworkView();

    /// <summary>Initializes the view.</summary>
    /// <param name="applicationView">The view object.</param>
    [MethodImpl]
    public extern void Initialize(CoreApplicationView applicationView);

    /// <summary>Associates a Window with a view.</summary>
    /// <param name="window">The Window to associate.</param>
    [MethodImpl]
    public extern void SetWindow(CoreWindow window);

    /// <summary>Loads the view.</summary>
    /// <param name="entryPoint">An identifier, such as a class name from the application code, that provides additional information about the view.</param>
    [MethodImpl]
    public extern void Load(string entryPoint);

    /// <summary>Passes execution to the view provider.</summary>
    [MethodImpl]
    public extern void Run();

    /// <summary>Returns the view to the uninitialized state.</summary>
    [MethodImpl]
    public extern void Uninitialize();
  }
}
