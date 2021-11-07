// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IStartupTaskActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information when an app is activated at device startup or user login.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(61938264, 21110, 19857, 134, 33, 84, 97, 24, 100, 213, 250)]
  public interface IStartupTaskActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the unique ID of the startup task</summary>
    /// <returns>
    /// </returns>
    string TaskId { get; }
  }
}
