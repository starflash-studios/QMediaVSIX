// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamDescriptor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Defines an interface implemented by a audio or video stream descriptor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1349714191, 59570, 16497, 176, 11, 235, 243, 55, 167, 107, 88)]
  public interface IMediaStreamDescriptor2 : IMediaStreamDescriptor
  {
    /// <summary>Gets or sets an app-defined label that identifies a stream in a MediaEncodingProfile that contains multiple streams.</summary>
    /// <returns>An app-defined label that identifies a stream.</returns>
    string Label { set; get; }
  }
}
