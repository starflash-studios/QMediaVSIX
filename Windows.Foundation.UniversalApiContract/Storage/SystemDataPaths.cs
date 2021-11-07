// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemDataPaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Gets some commonly used system wide folder locations based on the KNOWNFOLDERID naming pattern.</summary>
  [Static(typeof (ISystemDataPathsStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class SystemDataPaths : ISystemDataPaths
  {
    /// <summary>Gets the path to the fonts folder.</summary>
    /// <returns>The full path to the fonts folder.</returns>
    public extern string Fonts { [MethodImpl] get; }

    /// <summary>Gets the path to the ProgramData folder on the machine.</summary>
    /// <returns>The full path to the ProgramData folder.</returns>
    public extern string ProgramData { [MethodImpl] get; }

    /// <summary>Gets the path to the Public folder on the machine.</summary>
    /// <returns>The full path to the Public folder.</returns>
    public extern string Public { [MethodImpl] get; }

    /// <summary>Gets the path to the Public Desktop folder on the machine.</summary>
    /// <returns>The full path to the Public Desktop folder.</returns>
    public extern string PublicDesktop { [MethodImpl] get; }

    /// <summary>Gets the path to the Public Documents folder on the machine.</summary>
    /// <returns>The full path to the Public Documents folder.</returns>
    public extern string PublicDocuments { [MethodImpl] get; }

    /// <summary>Gets the path to the Public Downloads folder on the machine.</summary>
    /// <returns>The full path to the Public Downloads folder.</returns>
    public extern string PublicDownloads { [MethodImpl] get; }

    /// <summary>Gets the path to the Public Music folder on the machine.</summary>
    /// <returns>The full path to the Public Music folder.</returns>
    public extern string PublicMusic { [MethodImpl] get; }

    /// <summary>Gets the path to the Public Pictures folder on the machine.</summary>
    /// <returns>The full path to the Public Pictures folder.</returns>
    public extern string PublicPictures { [MethodImpl] get; }

    /// <summary>Gets the path to the Public Videos folder on the machine.</summary>
    /// <returns>The full path to the Public Videos folder.</returns>
    public extern string PublicVideos { [MethodImpl] get; }

    /// <summary>Gets the path to the Windows system folder.</summary>
    /// <returns>The full path to the Windows system folder.</returns>
    public extern string System { [MethodImpl] get; }

    /// <summary>Gets the path to the System folder regardless of the operating system architecture (x64, x86, ARM).</summary>
    /// <returns>The full path to the System folder.</returns>
    public extern string SystemHost { [MethodImpl] get; }

    /// <summary>Gets the path to the 32-bit Windows system folder.</summary>
    /// <returns>The full path to the 32-bit Windows system folder.</returns>
    public extern string SystemX86 { [MethodImpl] get; }

    /// <summary>Gets the path to the 64-bit Windows system folder.</summary>
    /// <returns>The full path to the 64-bit Windows system folder.</returns>
    public extern string SystemX64 { [MethodImpl] get; }

    /// <summary>Gets the path to the System folder for a machine using an ARM operating system.</summary>
    /// <returns>The full path to the System folder within an ARM operating system.</returns>
    public extern string SystemArm { [MethodImpl] get; }

    /// <summary>Gets a path to the user profiles for the computer.</summary>
    /// <returns>The full path to the user profiles.</returns>
    public extern string UserProfiles { [MethodImpl] get; }

    /// <summary>Gets a path to the Windows directory.</summary>
    /// <returns>The full path to the Windows directory.</returns>
    public extern string Windows { [MethodImpl] get; }

    /// <summary>Gets the paths to various system data folders.</summary>
    /// <returns>The app data paths associated with the system data.</returns>
    [MethodImpl]
    public static extern SystemDataPaths GetDefault();
  }
}
