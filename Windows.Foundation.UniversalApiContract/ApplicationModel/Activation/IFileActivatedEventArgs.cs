// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated because it is the program associated with a file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3140156467, 37809, 17133, 139, 38, 35, 109, 217, 199, 132, 150)]
  public interface IFileActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the files for which the app was activated.</summary>
    /// <returns>The files.</returns>
    IVectorView<IStorageItem> Files { get; }

    /// <summary>Gets the action associated with the activated file.</summary>
    /// <returns>The action.</returns>
    string Verb { get; }
  }
}
