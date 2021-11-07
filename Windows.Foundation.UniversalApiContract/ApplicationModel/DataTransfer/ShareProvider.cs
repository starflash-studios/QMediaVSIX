// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>This class represents a custom provider which can be shared.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IShareProviderFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ShareProvider : IShareProvider
  {
    /// <summary>Creates a new ShareProvider object.</summary>
    /// <param name="title">The title of the share provider.</param>
    /// <param name="displayIcon">The display icon of the share provider.</param>
    /// <param name="backgroundColor">The background color of the share provider.</param>
    /// <param name="handler">The handler of the share provider.</param>
    [MethodImpl]
    public extern ShareProvider(
      string title,
      RandomAccessStreamReference displayIcon,
      Color backgroundColor,
      ShareProviderHandler handler);

    /// <summary>Gets the title of the share provider.</summary>
    /// <returns>The title of the share provider.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the display icon of the share provider.</summary>
    /// <returns>The display icon of the share provider.</returns>
    public extern RandomAccessStreamReference DisplayIcon { [MethodImpl] get; }

    /// <summary>Gets the background color of the share provider.</summary>
    /// <returns>The background color of the share provider.</returns>
    public extern Color BackgroundColor { [MethodImpl] get; }

    /// <summary>Gets or sets the tag of the share provider.</summary>
    /// <returns>The tag of the share provider.</returns>
    public extern object Tag { [MethodImpl] get; [MethodImpl] set; }
  }
}
