// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithNeighboringFiles
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Search;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated because it is the program associated with the neighboring files.</summary>
  [Guid(1127981476, 57826, 18685, 183, 252, 181, 214, 238, 230, 80, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IFileActivatedEventArgsWithNeighboringFiles : 
    IFileActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the neighboring files of the files for which the app was activated.</summary>
    /// <returns>The StorageFile objects that represent the neighboring files of the files being passed to the app.</returns>
    StorageFileQueryResult NeighboringFilesQuery { get; }
  }
}
