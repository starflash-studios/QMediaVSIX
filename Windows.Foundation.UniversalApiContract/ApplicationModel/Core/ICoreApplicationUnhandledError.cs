// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationUnhandledError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Adds an error handling event for global error handling from the system that app models can use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4041362096, 56585, 17121, 176, 188, 224, 225, 49, 247, 141, 126)]
  public interface ICoreApplicationUnhandledError
  {
    /// <summary>Occurs when there is an error in an async completion handler, or an event handler, that wasn't otherwise handled by system or app code.</summary>
    event EventHandler<UnhandledErrorDetectedEventArgs> UnhandledErrorDetected;
  }
}
