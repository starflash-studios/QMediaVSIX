// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Defines an interface implemented by a audio or video stream descriptor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2163306094, 37623, 17694, 151, 210, 175, 216, 7, 66, 218, 112)]
  public interface IMediaStreamDescriptor
  {
    /// <summary>Specifies whether the stream is currently in use by the MediaStreamSource.</summary>
    /// <returns>**true** if the stream is currently in use by the MediaStreamSource; otherwise, **false**.</returns>
    bool IsSelected { get; }

    /// <summary>Gets or sets the name of the stream.</summary>
    /// <returns>The name of the stream.</returns>
    string Name { set; get; }

    /// <summary>Gets or sets the RFC-1766 language code for the stream.</summary>
    /// <returns>The RFC-1766 language code for the stream.</returns>
    string Language { set; get; }
  }
}
