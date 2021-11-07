// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Provides a control that hosts HTML content in an app. This interface requires IWebViewControl.</summary>
  [Guid(1295779577, 51423, 16844, 139, 213, 42, 148, 123, 32, 69, 3)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public interface IWebViewControl2
  {
    /// <summary>Injects a script into the IWebViewControl just after ContentLoading but before any other script is run on the page.</summary>
    /// <param name="script">
    /// </param>
    void AddInitializeScript(string script);
  }
}
