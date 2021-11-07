// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Provides string values for indexing names of common Windows file properties such as System.Title, and also references helper objects that provide indexing names for properties of specific file types (for example video files).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISystemProperties), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class SystemProperties
  {
    /// <summary>Gets the name of the System.Author property (one of the Windows file properties.</summary>
    /// <returns>The name of the System.Author file property.</returns>
    public static extern string Author { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Comment property (one of the Windows file properties.</summary>
    /// <returns>The name of the System.Comment file property.</returns>
    public static extern string Comment { [MethodImpl] get; }

    /// <summary>Gets the name of the System.ItemNameDisplay property (one of the Windows file properties.</summary>
    /// <returns>The name of the System.ItemNameDisplay file property.</returns>
    public static extern string ItemNameDisplay { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Keywords property (one of the Windows file properties.</summary>
    /// <returns>The name of the System.Keywords file property.</returns>
    public static extern string Keywords { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Rating property (one of the Windows file properties.</summary>
    /// <returns>The name of the System.Rating file property.</returns>
    public static extern string Rating { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Title property (one of the Windows file properties.</summary>
    /// <returns>The name of the System.Title file property.</returns>
    public static extern string Title { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of Windows file properties for **System.Audio**.</summary>
    /// <returns>A helper object that provides names for Windows file properties for **System.Audio**.</returns>
    public static extern SystemAudioProperties Audio { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of Windows system file properties for **System.GPS**.</summary>
    /// <returns>A helper object that provides names for GPS-related file properties.</returns>
    public static extern SystemGPSProperties GPS { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of system media file properties such as System.Media.Duration.</summary>
    /// <returns>A helper object that provides names for system media file properties.</returns>
    public static extern SystemMediaProperties Media { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of Windows file properties for **System.Music**.</summary>
    /// <returns>A helper object that provides names for Windows file properties for **System.Music**.</returns>
    public static extern SystemMusicProperties Music { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of Windows file properties for **System.Photo**.</summary>
    /// <returns>A helper object that provides names for Windows file properties for **System.Photo**.</returns>
    public static extern SystemPhotoProperties Photo { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of Windows file properties for **System.Video**.</summary>
    /// <returns>A helper object that provides names for Windows file properties for **System.Video**.</returns>
    public static extern SystemVideoProperties Video { [MethodImpl] get; }

    /// <summary>Gets an object that provides the indexing names of Windows file properties for **System.Image**.</summary>
    /// <returns>A helper object that provides names for Windows file properties for **System.Image**.</returns>
    public static extern SystemImageProperties Image { [MethodImpl] get; }
  }
}
