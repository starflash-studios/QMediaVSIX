// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.ResumingEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Represents a method that handles the app resumption event.</summary>
  /// <param name="sender">The sender.</param>
  [Guid(643406761, 41517, 18438, 167, 40, 172, 173, 193, 208, 117, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void ResumingEventHandler(object sender);
}
