// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.CachedFileOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Describes when Windows will request an update to a file.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CachedFileOptions : uint
  {
    /// <summary>Another app may be able to access the locally cached copy of the file without triggering an update.</summary>
    None = 0,
    /// <summary>An update always triggers when another app accesses the locally cached copy of the file.</summary>
    RequireUpdateOnAccess = 1,
    /// <summary>An update triggers when another app accesses the locally cached copy of the file if a network connection is available.  Otherwise, other apps can access the local file without triggering an update.</summary>
    UseCachedFileWhenOffline = 2,
    /// <summary>An update triggers when another app accesses the locally cached copy of the file if a network connection is available.  Otherwise, other apps are denied access to the local file.</summary>
    DenyAccessWhenOffline = 4,
  }
}
