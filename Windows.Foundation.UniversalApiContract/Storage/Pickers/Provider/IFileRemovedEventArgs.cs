﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IFileRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (FileRemovedEventArgs))]
  [Guid(319045031, 32714, 19499, 158, 202, 104, 144, 249, 240, 1, 133)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  internal interface IFileRemovedEventArgs
  {
    string Id { [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}