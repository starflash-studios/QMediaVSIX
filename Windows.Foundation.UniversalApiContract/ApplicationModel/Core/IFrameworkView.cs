// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IFrameworkView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Represents an app view provider.</summary>
  [Guid(4205534416, 35108, 17836, 173, 15, 160, 143, 174, 93, 3, 36)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IFrameworkView
  {
    /// <summary>Initializes the app view. Called when an app object is launched.</summary>
    /// <param name="applicationView">The default view provided by the app object. You can use this instance in your implementation to obtain the CoreWindow created by the app object, and register callbacks for the Activated event.</param>
    void Initialize(CoreApplicationView applicationView);

    /// <summary>Sets the current window for the app object's view.</summary>
    /// <param name="window">The current window for the app object.</param>
    void SetWindow(CoreWindow window);

    /// <summary>Loads or activates any external resources used by the app view before Run is called.</summary>
    /// <param name="entryPoint">The name of the entry point method for the activated type.</param>
    void Load(string entryPoint);

    /// <summary>Starts the app view.</summary>
    void Run();

    /// <summary>Uninitializes the app view and releases external resources.</summary>
    void Uninitialize();
  }
}
