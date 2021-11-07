// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to show its current view.</summary>
  [Guid(2467098443, 47145, 16636, 136, 244, 133, 19, 232, 166, 71, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IApplicationViewActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    int CurrentlyShownApplicationViewId { get; }
  }
}
