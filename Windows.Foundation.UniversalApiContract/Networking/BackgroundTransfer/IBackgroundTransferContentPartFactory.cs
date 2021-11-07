// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPartFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Creates a BackgroundTransferContentPart object.</summary>
  [Guid(2431621289, 31233, 18955, 159, 128, 160, 176, 187, 55, 15, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTransferContentPartFactory
  {
    /// <summary>Creates a BackgroundTransferContentPart object that indicates the specified content type.</summary>
    /// <param name="name">Identifies the content type.</param>
    /// <returns>The resultant BackgroundTransferContentPart.</returns>
    BackgroundTransferContentPart CreateWithName(string name);

    /// <summary>Creates a BackgroundTransferContentPart object that identifies the content type and name of the file.</summary>
    /// <param name="name">Identifies the content type.</param>
    /// <param name="fileName">The fully qualified file name; this includes the local path.</param>
    /// <returns>The resultant BackgroundTransferContentPart object.</returns>
    BackgroundTransferContentPart CreateWithNameAndFileName(
      string name,
      string fileName);
  }
}
