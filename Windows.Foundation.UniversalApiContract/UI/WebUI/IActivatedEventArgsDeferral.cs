// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IActivatedEventArgsDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Manages delayed activation for an app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3396165492, 25538, 17574, 185, 123, 217, 160, 60, 32, 188, 155)]
  public interface IActivatedEventArgsDeferral
  {
    /// <summary>Gets the app activation operation.</summary>
    /// <returns>The activation operation.</returns>
    ActivatedOperation ActivatedOperation { get; }
  }
}
