// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.TargetFileRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Lets an app that provides a save location specify the storageFile that represents the file to save and get a deferral so the app can respond asynchronously to a targetFileRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TargetFileRequest : ITargetFileRequest
  {
    /// <summary>Gets or sets the IStorageFile object that is provided to represent the file to save by the app that is providing the save location.</summary>
    /// <returns>The object that represents the file to save. The app that called the file picker in order to save will write content to this file.</returns>
    public extern IStorageFile TargetFile { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a targetFileRequestDeferral that the app providing the save location can use to respond asynchronously to a targetfilerequested event.</summary>
    /// <returns>The targetFileRequestDeferral that the providing app can use asynchronously to indicate that it is finished responding to a targetfilerequested event.</returns>
    [MethodImpl]
    public extern TargetFileRequestDeferral GetDeferral();
  }
}
