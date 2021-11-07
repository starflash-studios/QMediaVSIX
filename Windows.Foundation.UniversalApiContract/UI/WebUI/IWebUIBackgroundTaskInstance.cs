// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIBackgroundTaskInstance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides access to an instance of a background task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(603008037, 58103, 18241, 188, 156, 57, 69, 149, 222, 36, 220)]
  public interface IWebUIBackgroundTaskInstance
  {
    /// <summary>Gets or sets the success value for the background task. The success value is what is returned to the foreground instance of your app in the completed event.</summary>
    /// <returns>An app can set this property to **false** to indicate that the background task has failed. Otherwise this property is always **true.**</returns>
    bool Succeeded { get; set; }
  }
}
